# ReCapProject

![](https://st2.depositphotos.com/2172301/6557/v/950/depositphotos_65575193-stock-illustration-vector-template-of-car-rental.jpg) 
#

<b>ReCapProject is a car rental project that belongs to the C# programming language, adhering to SOLID principles and with an N-layer architecture structure; it is still under development.<br>

![](https://user-images.githubusercontent.com/77468985/108639775-4e7b5c80-74a7-11eb-91bc-2f1419e179db.png)

#
 
<b>The database was created based on the SQL Server Object Explorer section in Visual Studio 2019. At the bottom, you can see the field names and data types of the tables belonging to this database.  

![](https://user-images.githubusercontent.com/77468985/109575645-4fde0200-7b03-11eb-9570-bfa4d9e612fa.png)
![](https://user-images.githubusercontent.com/77468985/109575681-5ff5e180-7b03-11eb-8475-a8626ff76d5f.png)
![](https://user-images.githubusercontent.com/77468985/109575965-ed393600-7b03-11eb-8afa-aa04b858caf8.png)




![](https://user-images.githubusercontent.com/77468985/108639850-bcc01f00-74a7-11eb-99b8-21673b26989a.png) 

#

<b>ReCapProject consists of Entities, DataAccess, and Business layers. Initially, the ConsoleUI layer was used to simulate operations on these layers. Later, with the addition of WebAPI to the project, Postman was used for testing operations. Let's examine these layers closely:


## Entities Layer

<b>This layer is created for database objects. In the Concrete folder, there are only 'classes 'created for tables, while in the DTOs folder section, there are 'classes' created to combine properties in different tables. You can review the details using the links at the bottom.
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject2021/tree/master/Entities/Concrete">Concrete</a>
                                <ul type="circle">
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject2021/blob/master/Entities/Concrete/Brand.cs">Brands.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Entities/Concrete/Car.cs">Car.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Entities/Concrete/CarImage.cs">CarImage.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Entities/Concrete/Color.cs">Color.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Entities/Concrete/Customer.cs">Customer.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Entities/Concrete/Rental.cs">Rental.cs</a><br>
				</ul>
			</li>
			<td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Entities/DTOs">DTOs</a><br>
				<ul type="circle">
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Entities/DTOs/CarDetailDto.cs">CarDetailDto.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Entities/DTOs/UserForLoginDto.cs">UserForLoginDto.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Entities/DTOs/UserForRegisterDto.cs">UserForRegisterDto.cs</a><br>
				</ul>
			
</ul>		
                 
	


## Data Access Layer

<b> Database-related operations and database connections are located on this layer. You can review the details using the links at the bottom.

<ul type="circle">
					<td>&#128230;<ins><b>NuGet Packages</b></ins><br>
					<ul>
				<td>&#128205;<t> <code>Microsoft.EntityFrameworkCore.SqlServer(v3.1.11)</code><br>
					</ul>
					</ul>

<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/DataAccess/Abstract"> Abstract</a>
                                <ul type="circle">
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Abstract/IBrandDal.cs">IBrandDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Abstract/ICarDal.cs">ICarDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Abstract/ICarImageDal.cs">ICarImageDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Abstract/IColorDal.cs">IColorDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Abstract/ICustomerDal.cs">ICustomerDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Abstract/IRentalDal.cs">IRentDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Abstract/IUserDal.cs">IUserDal.cs</a><br>
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/DataAccess/Concrete"> Concrete</a>
                                <ul type="circle">
					<td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/DataAccess/Concrete/Ef">Entitiy Framework</a><br>
					<ul>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Concrete/Ef/CarsContext.cs">CarsContext.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfBrandDal.cs">EfBrandDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfCarDal.cs">EfCarDal.cs</a><br>
			        <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfCarImageDal.cs">EfCarImageDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfColorDal.cs">EfColorDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfCustomerDal.cs">EfCustomerDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfCarDal.cs">EfCarDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfRentalDal.cs">EfRentalDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfUserDal.cs">EfUserDal.cs</a><br>
</ul>
</ul>           
				<ul type="circle">
					<td>&#128206;<ins>The InMemory Folder is not a connection to the contents database, but was created for testing purposes only for startup.</ins> <br>
					<td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/DataAccess/Concrete/InMemory">In Memory</a><br>
					<ul>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/DataAccess/Concrete/InMemory/InMemoryDal.cs">InMemory.cs</a><br>
	
</ul>
</ul>

 </ul>	

## Business Layer

<b> Business rules for Operations contained in the DataAcess layer are included in this layer. You can review the details using the links at 
   
   <ul type="circle">
					<td>&#128230;<ins><b>NuGet Packages</b></ins><br>
					<ul>
				<td>&#128205;<t> <code>Autofac(v6.1.0)</code><br>
					<td>&#128205;<t> <code>Autofac.Extras.DynamicProxy(v6.0.0)</code><br>
					<td>&#128205;<t> <code>FluentValidation(v9.5.1)</code><br>
					<td>&#128205;<t> <code>Microsoft.AspNetCore.Http(v2.2.2)</code><br>
					<td>&#128205;<t> <code>Microsoft.AspNetCore.Http.Abstractions(v2.2.0)</code><br>
					<td>&#128205;<t> <code>Microsoft.AspNetCore.Http.Features(v5.0.3)</code><br>
					<td>&#128205;<t> <code>Microsoft.Extensions.DependencyInjection(v5.0.1)</code><br>
					</ul>
					</ul>

<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Business/Abstract"> Abstract</a>
                                <ul type="circle">
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Abstract/IAuthService.cs">IAuthService.cs</a><br>
		<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Abstract/IBrandService.cs">IBrandService.cs</a><br>	
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Abstract/ICarService.cs">ICarService.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Abstract/ICarImageService.cs">ICarImageService.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Abstract/IColorService.cs">IColorService.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Abstract/ICustomerService.cs">ICustomerService.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Abstract/IRentalService.cs">IRentalService.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Abstract/IUserService.cs">IUserService.cs</a><br>
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Business/BusinessAspect"> Business Aspect</a>
             <ul>
		                <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Business/BusinessAspect/Autofac">Autofac</a><br>
				<ul>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/BusinessAspect/Autofac/SecuredOperation.cs">SecuredOperation.cs</a><br>
</ul>	
</ul>
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Business/Concrete"> Concrete</a>
             <ul>
		                <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Concrete/AuthManager.cs">AuthManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Concrete/BrandManager.cs">BrandManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Concrete/CarManager.cs">CarManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Concrete/CarImageManager.cs">CarImageManager.cs</a><br>	
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Concrete/ColorManager.cs">ColorManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Concrete/CustomerManager.cs">CustomerManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Concrete/RentalManager.cs">RentalManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Concrete/UserManager.cs">UserManager.cs</a><br>
</ul>
</ul>
				<ul type="circle">
					<td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Business/Constants">Constans</a><br>
					<ul>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/Constants/Messages.cs">Messages.cs</a><br>
	
</ul>
</ul>
                                <ul type="circle">
					<td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Business/DependencyResolvers">Dependency Resolvers</a><br>
					<ul>
				<td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Business/DependencyResolvers/Autofac">Autofac</a><br>
					<ul>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs">AutofacBusinessModule.cs</a><br>
				
</ul>
					
			
</ul>
</ul>
                                <ul type="circle">
					<td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Business/ValidationRules">Validation Rules</a><br>
					<ul>
				<td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Business/ValidationRules/FluentValidation">Fluent Validation</a><br>
					<ul>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/BrandValidator.cs">BrandValidator.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/CarValidator.cs">CarValidator.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/CarImageValidator.cs">CarImageValidator.cs</a><br>	
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/ColorValidator.cs">ColorValidator.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs">CustomerValidator.cs</a><br>
			        <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/RentalValidator.cs">RentalValidator.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Business/ValidationRules/FluentValidation/UserValidator.cs">UserValidator.cs</a><br>
				
</ul>
					
			
</ul>

</ul>	

## Core Layer
<b>The Core layer is a layer where operations are generalized with generic structures, with potential that can be used for each project. CRUD operations are generalized with this layer only for objects that depend on the IEntity interface. You can review the details using the links at the bottom.
<ul type="circle">
					<td>&#128230;<ins><b>NuGet Packages</b></ins><br>
					<ul>
					<td>&#128205;<t> <code>Autofac(v6.1.0)</code><br>	
						<td>&#128205;<t> <code>Autofac.Extras.DynamicProxy(v6.0.0)</code><br>
					<td>&#128205;<t> <code>FluentValidation(v9.5.1)</code><br>
				<td>&#128205;<t> <code>Microsoft.AspNetCore.Http.Features(v5.0.3)</code><br>
				<td>&#128205;<t> <code>Microsoft.EntityFrameworkCore.SqlServer(v3.1.11)</code><br>
				<td>&#128205;<t> <code>Microsoft.IdentityModel.Tokens(v6.8.0)</code><br>
				<td>&#128205;<t> <code>System.IdentityModel.Tokens.Jwt(v6.8.0)</code><br>
				
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Aspects">Aspects</a>
                                <ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Aspects/Autofac">Autofac</a><br>
					<ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Aspects/Autofac/Validation">Validation</a><br>	 
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs">ValidationAspect.cs</a><br>
				
</ul>	
</ul>
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/CrossCuttingConcerns">Cross Cutting Concerns</a>
                                <ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/CrossCuttingConcerns/Validation">Validation</a><br>
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/eminbozgeyikReCapProject/blob/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs">ValidationTool.cs</a><br>
					</ul>
						 </ul></ul>

<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/DataAccess">Data Access</a>
                                <ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/DataAccess/EntitiyFramework">Entity Framework</a><br>
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/DataAccess/EntitiyFramework/EfEntityRepositoryBase.cs">EfEntityRepositoryBase.cs</a><br>
					</ul>
			</li>
			<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/DataAccess/IEntityRepository.cs">IEntitiyRepository.cs</a>
				</ul>
				
</ul>	
	
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Entities">Entities</a>
                                <ul type="circle">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Entities/Concrete">Concrete</a>
                                <ul type="circle">
			                 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Entities/Concrete/OperationClaim.cs">OperationClaim.cs</a><br>
					 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Entities/Concrete/User.cs">User.cs</a><br>
                                   <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Entities/Concrete/UserOperationClaim.cs">UserOperationClaim.cs</a><br>
		
</ul>
					 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Entities/IDto.cs">IDTO</a><br>
					 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Entities/IEntity.cs">IEntity</a><br>
                                   
		
</ul>
				
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Extensions">Extensions</a>
                                <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Extensions/ClaimExtensions.cs">ClaimExtensions.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Extensions/ClaimsPrincipalExtensions.cs">ClaimsPrincipalExtensions.cs</a><br>
				</ul>
				
</ul>	
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Utilities">Utilities</a><br>
	<ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Utilities/Business">Business</a><br>
						 <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Business/BusinessRules.cs">BusinessRules.cs</a><br>
</ul>
</ul>
	<ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Utilities/FileHelper">FileHelper</a><br>
						 <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/FileHelper/FileHelper.cs">FileHelper.cs</a><br>
</ul>
</ul>
<ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Utilities/IOC">IOC</a><br>
						 <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/IOC/ServiceTool.cs">ServiceTool.cs</a><br>
</ul>
</ul>
	<ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Interceptors">Interceptors</a><br>
						 <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs">AspectInterceptorSelector.cs</a><br>
						 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Interceptors/MethodInterception.cs">MethodInterception.cs</a><br>
							 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs">MethodInterceptionBaseAttribute.cs</a><br>
						  
						
						
							
</ul>
</ul>
                                <ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Utilities/Results">Results</a><br>
						 <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Results/DataResult.cs">DataResult.cs</a><br>
						 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Results/ErrorDataResult.cs">ErrorDataResult.cs</a><br>
							 <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Results/ErrorResult.cs">ErrorResult.cs</a><br>
						  <td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Results/IDataResult.cs">IDataResult.cs</a><br>
						<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Results/IResult.cs">IResult.cs</a><br>	  
							<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Results/Result.cs">Result.cs</a><br>
								<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Results/SuccessDataResult.cs">SuccessDataResult.cs</a><br>
							<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Results/SuccessResult.cs">SuccessResult.cs</a><br>
						
							
</ul>
</ul>
	<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyikReCapProject/tree/master/Core/Utilities/Security">Security</a>
                                <ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Utilities/Security/Encryption">Encryption</a><br>
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Security/Encryption/SecurityKeyHelper.cs">SecurityKeyHelper.cs</a><br>
			<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Security/Encryption/SigningCredentialsHelper.cs">SigningCredentialsHelper.cs</a><br>
					</ul>
						 </ul>
	 <ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Utilities/Security/Hashing">Hashing</a><br>
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Security/Hashing/HashingHelper.cs">HashingHelper.cs</a><br>
					</ul>
						 </ul>
	<ul type="circle">
					 <td>&#128194;<a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/Core/Utilities/Security/JWT">JWT</a><br>
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Security/JWT/AccessToken.cs">AccessToken.cs</a><br>
		<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Security/JWT/ITokenHelper.cs">ITokenHelper.cs</a><br>
		<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Security/JWT/JwtHelper.cs">JWTHelper.cs</a><br>
		<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/Core/Utilities/Security/JWT/TokenOptions.cs">TokenOptions.cs</a><br>
					</ul>
						 </ul>
	
</ul>
			
</ul>
				
## WebAPI 

<ul type="circle">
					<td>&#128230;<ins><b>NuGet Packages</b></ins><br>
					<ul>
				<td>&#128205;<t> <code>Autofac.Extensions.DependencyInjection(v7.1.0)</code><br>
				<td>&#128205;<t> <code>Microsoft.AspNetCore.Authentication.JwtBearer(v3.1.12)</code><br>
				
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/tree/master/WebAPI/Controllers"> Controllers</a>
                                <ul type="circle">
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/Controllers/AuthController.cs">AuthController.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/Controllers/BrandsController.cs">BrandsController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/Controllers/CarsController.cs">CarsController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/Controllers/CarImagesController.cs">CarImagesController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/Controllers/ColorsController.cs">ColorsController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/Controllers/CustomersController.cs">CustomersController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/Controllers/RentalsController.cs">RentalsController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/Controllers/UsersController.cs">UsersController.cs</a><br>
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#x1F4C4; </tr><a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/Program.cs"> Program.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/Startup.cs">Startup.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/WebAPI/WeatherForecast.cs">WeatherForecast.cs</a><br>
				
</ul>
			
	
</ul>


![](https://user-images.githubusercontent.com/77468985/108639915-13c5f400-74a8-11eb-8bf3-28ac80e569ee.png)

## ConsoleUI

<b>This layer is used to control written operations. Operations tested in this layer<td>&#128279;<a href="https://github.com/eminbozgeyik/ReCapProject/blob/master/ConsoleUI/Program.cs">here you can reach</a>. At the bottom, you can see the results of some operations as an example.
	
![](https://user-images.githubusercontent.com/77468985/108639973-525bae80-74a8-11eb-91e3-240005af63cc.png)
	
![](https://user-images.githubusercontent.com/77468985/108640042-9c449480-74a8-11eb-8995-7a9576bd1502.png)	

![](https://user-images.githubusercontent.com/77468985/108640122-f2193c80-74a8-11eb-846a-bade942d39a0.png)

![](https://user-images.githubusercontent.com/77468985/108639532-10316d80-74a6-11eb-8686-ac8dc1a716d9.png)
##

<b>With the addition of the WebAPI layer to the project, Postman was used as a test tool, as the ConsoleUI layer was not sufficient. At the bottom, you can see the test results of some operations as an example.<br>
<br>
<b><em>-<ins>Cars<br></ins>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/108640191-46bcb780-74a9-11eb-83d7-a3037cb2ef6d.png)
<br>
<br>
<br>
<b><em>-<ins>Rental<br></ins>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/108640225-84214500-74a9-11eb-93b2-70635c7b1253.png)
<br>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/108640252-969b7e80-74a9-11eb-90dc-f10667fc4e59.png)

<br>
<br>
<br>

![](https://user-images.githubusercontent.com/77468985/108640276-c21e6900-74a9-11eb-9bda-0a937d14ba9a.png)
<br>
<br>
<br>
<b><em>-<ins>User<br></ins>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109572822-f1af2000-7afe-11eb-8f46-799d590ec9c8.png)
<br>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109572859-055a8680-7aff-11eb-96d8-7bad598e3805.png)
<br>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109572923-1e633780-7aff-11eb-9c43-c6c7e7e30c4e.png)
<br>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109572993-3b980600-7aff-11eb-853e-7190a66dd2f0.png)
<br>
<br>
<br>
<b><em>-<ins>CarImages<br></ins>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109799733-6c765900-7c2d-11eb-9552-8fa85c6b8895.png)
<br>
<br>
<br>	
![](https://user-images.githubusercontent.com/77468985/109800103-d7279480-7c2d-11eb-84c0-1eb24f2c62ae.png)
<br>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109800163-ead2fb00-7c2d-11eb-94d0-64e3e0997f48.png)
