﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService, IWebHostEnvironment webHostEnvironment)
        {
            _carService = carService;
            
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if(result.Success)
            { return Ok(result);  }
            return BadRequest(result);
        
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            { return Ok(result.Data); }
            return BadRequest(result);

        }
        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }

        [HttpGet("getcarsbymodelyear")]
        public IActionResult GetCarsByModelYear(int year=2018)
        {
            var result = _carService.GetCarsByModelYear(year);
            if (result.Success)
            { return Ok(result.Data); }
            return BadRequest(result);

        }
        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarDetails(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success)
            { return Ok(result.Data); }
            return BadRequest(result);

        }
        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success)
            { return Ok(result.Data); }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }


    }
}
