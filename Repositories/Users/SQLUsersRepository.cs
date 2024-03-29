using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ohjelmistokehitysprojekti_2_backend.Data;
using ohjelmistokehitysprojekti_2_backend.Models.Domain;
using ohjelmistokehitysprojekti_2_backend.Models.DTO.Users;

namespace ohjelmistokehitysprojekti_2_backend.Repositories.Users
{
    public class SQLUsersRepository : IUsersRepository
    {
        private readonly OKP2DbContext dbContext;

        public SQLUsersRepository(OKP2DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<User?> CreateAsync(UserRegisterDto userRegisterDto)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userRegisterDto.Password);

            var newUser = new User()
            {
                Username = userRegisterDto.Username,
                Email = userRegisterDto.Email,
                PasswordHash = passwordHash,
                Role = "User"
            };

            await dbContext.Users.AddAsync(newUser);
            await dbContext.SaveChangesAsync();
            return newUser;
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var user = await dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        public async Task<User?> GetByUsername(UserLoginDto userLoginDto)
        {
            var user = await dbContext.Users.FirstOrDefaultAsync(x => x.Username.ToLower() == userLoginDto.Username.ToLower());

            if (user == null)
            {
                return null;
            }

            return user;
        }
    }
}