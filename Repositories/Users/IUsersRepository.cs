using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ohjelmistokehitysprojekti_2_backend.Models.Domain;
using ohjelmistokehitysprojekti_2_backend.Models.DTO.Users;

namespace ohjelmistokehitysprojekti_2_backend.Repositories.Users
{
    public interface IUsersRepository
    {
        Task<User?> GetByIdAsync(Guid id);
        Task<User?> CreateAsync(UserRegisterDto userRegisterDto);

        Task<User?> GetByUsername(UserLoginDto userLoginDto);
    }
}