using Microsoft.EntityFrameworkCore;
using AddressBookAPI.Models;

namespace AddressBookAPI.Data
{
    public class AddressBookContext(DbContextOptions<AddressBookContext> options) : DbContext(options)
    {
        public DbSet<Profile> Profiles { get; set; }
    }

}
