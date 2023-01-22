using Microsoft.EntityFrameworkCore.Metadata;
using PetClinicWebApp.Api.Dto.CustomerDto;
using PetClinicWebApp.Api.Mappers.CustomerMapper;
using PetClinicWebApp.Api.Models;

namespace PetClinicWebApp.Api.Tests.MapperTests;

[TestFixture]
public class CustomerMapperTests
{
    private CustomerReadOnlyMapper _customerReadOnlyMapper;

    [SetUp]
    public void Init()
    {
        _customerReadOnlyMapper = new CustomerReadOnlyMapper();
    }

    #region Testing > CustomerReadOnlyMapper > MapCustomerReadOnlyDto2Customer
    [Test]
    public void MapCustomerReadOnlyDto2Customer_ParameterCustomerIsNull_ReturnsNewAndEmptyCustomerReadOnlyDto()
    {
        var result = _customerReadOnlyMapper.MapCustomer2CustomerReadOnlyDto(null);
        Assert.That(result, Is.InstanceOf<CustomerReadOnlyDto>());
    }

    [Test]
    public void MapCustomerReadOnlyDto2Customer_ParameterCustomerIsNotNullWithPropertyValues_ReturnsNewCustomerReadOnlyDtoWithPropertyValues()
    {
        var fakeCustomer = new Customer()
        {
            FirstName = "Thomas"
        };
        var result = _customerReadOnlyMapper.MapCustomer2CustomerReadOnlyDto(fakeCustomer);
        Assert.That(result.FirstName, Is.EqualTo("Thomas"));
    }

    #endregion

    #region Testing > CustomerReadOnlyMapper > MapCustomerReadOnlyDto2Customer

    [Test]
    public void MapCustomerReadOnlyDto2Customer_ParameterCustomerReadOnlyDtoIsNull_ReturnsNewAndEmptyCustomer()
    {
        var result = _customerReadOnlyMapper.MapCustomerReadOnlyDto2Customer(null);
        Assert.That(result, Is.InstanceOf<Customer>());

    }

    [Test]
    public void MapCustomerReadOnlyDto2Customer_ParameterCustomerReadOnlyDtoIsNotNullWithPropertyValues_ReturnsNewCustomerWithPropertyValues()
    {
        var fakeCustomerReadOnlyDto = new CustomerReadOnlyDto()
        {
            FirstName = "Thomas"
        };
        var result = _customerReadOnlyMapper.MapCustomerReadOnlyDto2Customer(fakeCustomerReadOnlyDto);
        Assert.That(result.FirstName, Is.EqualTo("Thomas"));
    }

    #endregion

    #region Testing CustomMapper > MapCustomerReadOnlyDtos2Customers

    [Test]
    public void MapCustomerReadOnlyDtos2Customers_ParameterListOfCustomerReadOnlyDtoIsNull_ReturnsNewListOfCustomers()
    {
        var result = _customerReadOnlyMapper.MapCustomerReadOnlyDtos2Customers(null);
        Assert.That(result, Is.InstanceOf<List<Customer>>());
    }

    [Test]
    public void MapCustomerReadOnlyDtos2Customers_Parameter_ListOfCustomerReadOnlyDtoIsNull_ReturnsEmptyListOfCustomers()
    {
        var result = _customerReadOnlyMapper.MapCustomerReadOnlyDtos2Customers(null);
        Assert.That(result, Has.Count.EqualTo(0));

    }

    [Test]
    public void MapCustomerReadOnlyDtos2Customers_ParameterListOfCustomerReadOnlyDtoIsNotNullAndContainsAtLeastOneItem_ReturnsListOfCustomersWithSameItemCountAsPassedList()
    {
        var fakeCustomerReadOnlyDtos = CreateFakeCustomerReadOnlyDtos();

        var result = _customerReadOnlyMapper.MapCustomerReadOnlyDtos2Customers(fakeCustomerReadOnlyDtos);
        Assert.That(result, Has.Count.EqualTo(2));
    }

    [Test]
    public void MapCustomerReadOnlyDtos2Customers_ParameterListOfCustomerReadOnlyDtoIsNotNullAndContainsAtLeastOneItem_PropertiesAreProperlyMatched()
    {
        var fakeCustomerReadOnlyDtos = CreateFakeCustomerReadOnlyDtos();

        var result = _customerReadOnlyMapper.MapCustomerReadOnlyDtos2Customers(fakeCustomerReadOnlyDtos);
        Assert.That(result[0].FirstName, Is.EqualTo("Tatjana"));
    }

    #endregion

    #region Testing CustomMapper > MapCustomers2CustomerReadOnlyDtos

    [Test]
    public void MapCustomers2CustomerReadOnlyDtos_ParameterListOfCustomersIsNotNullAndHasValues_PropertiesAreProperlyMatched()
    {
        var fakeCustomers = CreateFakeCustomers();

        var result = _customerReadOnlyMapper.MapCustomers2CustomerReadOnlyDtos(fakeCustomers);
        Assert.That(result[0].FirstName, Is.EqualTo("Theodore"));
    }


    [Test]
    public void MapCustomers2CustomerReadOnlyDtos_ParameterListOfCustomersIsNotNullAndContainsAtLeastOneItem_ReturnsListOfCustomerReadOnlyDtosWithSameItemCountAsPassedList()
    {
        var fakeCustomers = CreateFakeCustomers();

        var result = _customerReadOnlyMapper.MapCustomers2CustomerReadOnlyDtos(fakeCustomers);
        Assert.That(result, Has.Count.EqualTo(2));
    }

    [Test]
    public void MapCustomers2CustomersReadOnlyDtos_ParameterListOfCustomersIsNull_ReturnsNewListOfCustomerReadonlyDtos()
    {
        var result = _customerReadOnlyMapper.MapCustomers2CustomerReadOnlyDtos(null);
        Assert.That(result, Is.InstanceOf<List<CustomerReadOnlyDto>>());
    }

    [Test]
    public void MapCustomers2CustomersReadOnlyDtos_ParameterListOfCustomersIsNull_ReturnsEmptyListOfCustomerReadonlyDtos()
    {
        var result = _customerReadOnlyMapper.MapCustomers2CustomerReadOnlyDtos(null);
        Assert.That(result, Has.Count.EqualTo(0));
    }


    #endregion

    #region Helper methods

    private static List<CustomerReadOnlyDto> CreateFakeCustomerReadOnlyDtos()
    {
        var fakeCustomerReadOnlyDtos = new List<CustomerReadOnlyDto>()
        {
            new CustomerReadOnlyDto()
            {
                FirstName = "Tatjana",
                LastName = "Testova"
            },
            new CustomerReadOnlyDto
            {
                FirstName = "Timothy",
                LastName = "Testman",
            }
        };
        return fakeCustomerReadOnlyDtos;
    }
    private static List<Customer> CreateFakeCustomers()
    {
        var fakeCustomers = new List<Customer>()
        {
            new Customer
            {
                FirstName = "Theodore",
                LastName = "Testman"
            },
            new Customer
            {
                FirstName = "Thalia",
                LastName = "Testopulos"
            }
        };
        return fakeCustomers;
    }

    #endregion
}