﻿using PetClinicWebApp.Api.Dto.CustomerDto;
using PetClinicWebApp.Api.Interfaces;
using PetClinicWebApp.Api.Models;

namespace PetClinicWebApp.Api.Mappers.CustomerMapper;

public class CustomerMapper : ICustomerMapper
{
    public Customer MapCustomerReadOnlyDto2Customer(CustomerReadOnlyDto? customerReadOnlyDto)
    {
        return new Customer
        {
            FirstName = customerReadOnlyDto.FirstName,
            LastName = customerReadOnlyDto.LastName,
            DateOfBirth = customerReadOnlyDto.DateOfBirth,
            Age = customerReadOnlyDto.Age,
            PhoneNumber = customerReadOnlyDto.PhoneNumber,
            Email = customerReadOnlyDto.Email,
            Street = customerReadOnlyDto.Street,
            ZipCode = customerReadOnlyDto.ZipCode,
            City = customerReadOnlyDto.City,
            CreationDate = customerReadOnlyDto.CreationDate,
            LastChangedAt = customerReadOnlyDto.LastChangedAt
        };
    }

    public CustomerReadOnlyDto MapCustomer2CustomerReadOnlyDto(Customer? customer)
    {
        if (customer is null)
        {
            return new CustomerReadOnlyDto();
        }

        return new CustomerReadOnlyDto
        {
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            DateOfBirth = customer.DateOfBirth,
            Age = customer.Age,
            PhoneNumber = customer.PhoneNumber,
            Email = customer.Email,
            Street = customer.Street,
            ZipCode = customer.ZipCode,
            City = customer.City,
            CreationDate = customer.CreationDate,
            LastChangedAt = customer.LastChangedAt
        };
    }
}