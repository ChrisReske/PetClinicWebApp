using PetClinicWebApp.Api.Dto.CustomerDto;
using PetClinicWebApp.Api.Models;

namespace PetClinicWebApp.Api.Interfaces;

public interface ICustomerMapper
{
    Customer MapCustomerReadOnlyDto2Customer(CustomerReadOnlyDto? customerReadOnlyDto);
    CustomerReadOnlyDto MapCustomer2CustomerReadOnlyDto(Customer customer);
    
    List<Customer> MapCustomerReadOnlyDtos2Customers(List<CustomerReadOnlyDto> customerReadOnlyDtos);
    List<CustomerReadOnlyDto> MapCustomers2CustomerReadOnlyDtos(List<Customer> customers);
}