﻿using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentalValidator))]
        [SecuredOperation("user")]
        public IResult Add(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckReturnDate(rental.CarId));
            if (result != null)
            { return result; }

            else {_rentalDal.Add(rental);
            return new SuccessResult("Araç kiralandı"); }
            
            
        }
        [SecuredOperation("admin")]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailsDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailsDto>>(_rentalDal.GetRentalDetails(), Messages.RentalDetailsListed);

        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        private IResult CheckReturnDate(int id)
        {
            var result = _rentalDal.GetAll(r => r.CarId == id && r.ReturnDate == null);
            if (result.Count ==0)
            { return new SuccessResult(); }
            else
            { return new ErrorResult("Aracı kiralayamazsınız; araç henüz teslim edilmemiş."); }
        }
    }
    
}
