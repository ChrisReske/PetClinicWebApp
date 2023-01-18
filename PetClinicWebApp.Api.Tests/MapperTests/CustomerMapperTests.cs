using PetClinicWebApp.Api.Dto.CustomerDto;
using PetClinicWebApp.Api.Mappers.CustomerMapper;

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
    public void MapCustomerReadOnlyDto2Customer_ParameterCustomerReadOnlyDtoIsNull_ReturnsNewAndEmptyCustomer()
    {
        var result = _customerMapper.MapCustomer2CustomerReadOnlyDto(null);
        Assert.That(result, Is.InstanceOf<CustomerReadOnlyDto>());
    }

    #endregion
}