using PetClinicWebApp.Api.Dto.CustomerDto;
using PetClinicWebApp.Api.Models;

namespace PetClinicWebApp.Api.Interfaces;

public interface ICustomerMapper
{
    Customer MapCustomer2CustomerReadOnlyDto(CustomerReadOnlyDto source);
    CustomerReadOnlyDto MapCustomerReadOnlyDto2Customer(Customer source);
}