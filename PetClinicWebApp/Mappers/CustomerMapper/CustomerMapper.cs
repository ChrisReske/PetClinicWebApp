using PetClinicWebApp.Api.Dto.CustomerDto;
using PetClinicWebApp.Api.Interfaces;
using PetClinicWebApp.Api.Models;

namespace PetClinicWebApp.Api.Mappers.CustomerMapper;

public class CustomerMapper : ICustomerMapper
{
    public Customer MapCustomer2CustomerReadOnlyDto(CustomerReadOnlyDto source)
    {
        return new Customer
        {
            FirstName = source.FirstName,
            LastName = source.LastName,
            DateOfBirth = source.DateOfBirth,
            Age = source.Age,
            PhoneNumber = source.PhoneNumber,
            Email = source.Email,
            Street = source.Street,
            ZipCode = source.ZipCode,
            City = source.City,
            CreationDate = source.CreationDate,
            LastChangedAt = source.LastChangedAt
        };
    }

    public CustomerReadOnlyDto MapCustomerReadOnlyDto2Customer(Customer source)
    {
        return new CustomerReadOnlyDto
        {
            FirstName = source.FirstName,
            LastName = source.LastName,
            DateOfBirth = source.DateOfBirth,
            Age = source.Age,
            PhoneNumber = source.PhoneNumber,
            Email = source.Email,
            Street = source.Street,
            ZipCode = source.ZipCode,
            City = source.City,
            CreationDate = source.CreationDate,
            LastChangedAt = source.LastChangedAt
        };
    }
}