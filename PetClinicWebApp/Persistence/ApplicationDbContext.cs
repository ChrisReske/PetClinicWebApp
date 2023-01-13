using Microsoft.EntityFrameworkCore;
using PetClinicWebApp.Api.Models;

namespace PetClinicWebApp.Api.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }

    public DbSet<Customer> Customers { get; set; }
}