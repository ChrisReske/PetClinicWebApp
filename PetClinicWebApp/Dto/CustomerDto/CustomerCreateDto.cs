﻿namespace PetClinicWebApp.Api.Dto.CustomerDto;

public class CustomerCreateDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Street { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastChangedAt { get; set; }

}