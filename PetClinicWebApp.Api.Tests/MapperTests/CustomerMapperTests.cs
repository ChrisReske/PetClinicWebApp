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

    #region Testing CustomMapper > MapCustomerReadOnlyDtos2Customers

    [Test]
    public void MapCustomerReadOnlyDtos2Customers_Parameter_ListOfCustomerReadOnlyDtoIsNull_ReturnsNewListOfCustomers()
    {
        var result = _customerMapper.MapCustomerReadOnlyDtos2Customers(null);
        Assert.That(result, Is.InstanceOf<List<Customer>>());
    }

    [Test]
    public void MapCustomerReadOnlyDtos2Customers_Parameter_ListOfCustomerReadOnlyDtoIsNull_ReturnsEmptyListOfCustomers()
    {
        var result = _customerMapper.MapCustomerReadOnlyDtos2Customers(null);
        Assert.That(result, Has.Count.EqualTo(0));

    }

    [Test]
    public void MapCustomerReadOnlyDtos2Customers_ParameterListOfCustomerReadOnlyDtoIsNotNullAndContainsAtLeastOneItem_ReturnsListOfCustomersWithSameItemCountAsPassedList()
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

        var result = _customerMapper.MapCustomerReadOnlyDtos2Customers(fakeCustomerReadOnlyDtos);
        Assert.That(result, Has.Count.EqualTo(2));
    }

    #endregion
}