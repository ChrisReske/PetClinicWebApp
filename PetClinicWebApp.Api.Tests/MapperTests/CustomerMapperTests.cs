using PetClinicWebApp.Api.Dto.CustomerDto;
using PetClinicWebApp.Api.Mappers.CustomerMapper;
using PetClinicWebApp.Api.Models;

namespace PetClinicWebApp.Api.Tests.MapperTests;

[TestFixture]
public class CustomerMapperTests
{
    private CustomerMapper _customerMapper;

    [SetUp]
    public void Init()
    {
        _customerMapper = new CustomerMapper();
    }

    #region Testing > CustomerMapper > MapCustomerReadOnlyDto2Customer
    [Test]
    public void MapCustomerReadOnlyDto2Customer_ParameterCustomerIsNull_ReturnsNewAndEmptyCustomerReadOnlyDto()
    {
        var result = _customerMapper.MapCustomer2CustomerReadOnlyDto(null);
        Assert.That(result, Is.InstanceOf<CustomerReadOnlyDto>());
    }

    [Test]
    public void MapCustomerReadOnlyDto2Customer_ParameterCustomerIsNotNullWithPropertyValues_ReturnsNewCustomerReadOnlyDtoWithPropertyValues()
    {
        var fakeCustomer = new Customer()
        {
            FirstName = "Thomas"
        };
        var result = _customerMapper.MapCustomer2CustomerReadOnlyDto(fakeCustomer);
        Assert.That(result.FirstName, Is.EqualTo("Thomas"));
    }

    #endregion

    #region Testing > CustomerMapper > MapCustomerReadOnlyDto2Customer

    [Test]
    public void MapCustomerReadOnlyDto2Customer_ParameterCustomerReadOnlyDtoIsNull_ReturnsNewAndEmptyCustomer()
    {
        var result = _customerMapper.MapCustomerReadOnlyDto2Customer(null);
        Assert.That(result, Is.InstanceOf<Customer>());

    }

    [Test]
    public void MapCustomerReadOnlyDto2Customer_ParameterCustomerReadOnlyDtoIsNotNullWithPropertyValues_ReturnsNewCustomerWithPropertyValues()
    {
        var fakeCustomerReadOnlyDto = new CustomerReadOnlyDto()
        {
            FirstName = "Thomas"
        };
        var result = _customerMapper.MapCustomerReadOnlyDto2Customer(fakeCustomerReadOnlyDto);
        Assert.That(result.FirstName, Is.EqualTo("Thomas"));
    }


    #endregion

}