using M2Helper.Data;
using M2Helper.Models;
using M2Helper.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Service
{
    public class UsersService
    {
        private UsersRepository usersRepository;
        private ApplicationDbContext applicationDbContext;
        public UsersService()
        {
            applicationDbContext = new ApplicationDbContext();
            usersRepository = new UsersRepository(applicationDbContext);
        }
        public async Task<Users> GetUserByIdAsync(int userId)
        {
            return await usersRepository.GetUserByIdAsync(userId);
        }
        public async Task<Users> GetUserByEmailAsync(string email)
        {
            return await usersRepository.GetUserByEmailAsync(email);
        }

        public async Task<IEnumerable<Users>> GetAllUsersAsync()
        {
            return await usersRepository.GetAllUsersAsync();
        }

        public async Task AddUserAsync(Users user)
        {
            await usersRepository.AddUserAsync(user);
        }

        public async Task UpdateUserAsync(Users user)
        {
            await usersRepository.UpdateUserAsync(user);
        }

        public async Task DeleteUserAsync(int userId)
        {
            await usersRepository.DeleteUserAsync(userId);
        }
    }
}
