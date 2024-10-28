using FHussien_DatabaseSolution.Models;
using System.Net;

namespace FHussien_DatabaseSolution.Seed
{
    public class Data
    {
        public List<Company> GetCompanies()
        {
            return Enumerable.Range(1, 100).Select(i => new Company
            {
                Id= i,
                Name = $"Company {i}",
                Location = $"Location {i}"
            }).ToList();
        }

        public List<Role> GetRoles() {
            return new List<Role> {
                new Role
                {
                    Id = 1,
                    Name = "Admin",
                    Description = "Administrator"
                },
                new Role
                {
                    Id = 2,
                    Name = "User",
                    Description = "Flat User"
                }
            };
        }

        public List<UserInformation> GetUserInformations() {

            return Enumerable.Range(1, 100).Select(i => new UserInformation
            {
                Id = i,
                FirstName = $"First Name {i}",
                LastName = $"Last Name {i}",
                Birthdate = new DateOnly(1995, 5, 9)
            }).ToList();
        }

        public List<User> GetUsers() {
            var admins = Enumerable.Range(1, 50).Select(i => new User
            {
                Id = i,
                UserName = $"Admin {i}",
                Email = $"admin.email{i}@email.com",
                Password =  "admin",
                CompanyId = i,
                RoleId = 1,
                UserInformationId = i,
            }).ToList();

            var users = Enumerable.Range(51, 50).Select(i => new User
            {
                Id = i,
                UserName = $"User {i}",
                Email = $"user.email{i}@email.com",
                Password = "password",
                CompanyId = i,
                RoleId = 2,
                UserInformationId = i,
            }).ToList();

            var combined = admins.Concat(users).ToList();

            return combined;
        }
    }
}
