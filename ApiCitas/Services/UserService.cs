﻿using ApiCitas.Data.Repositories;
using ApiCitas.Models;

namespace ApiCitas.Services
{
    public class UserService : IUserService
    {
        // esto es como un logic  validaciones antes de llegar al repo
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _userRepository.GetAll();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetById(id);
        }

        public async Task<int> CreateUser(User user)
        {
            return await _userRepository.Create(user);
        }

        public async Task<int> UpdateUser(User user)
        {
            return await _userRepository.Update(user);
        }

        public async Task<int> DeleteUser(int id)
        {
            return await _userRepository.Delete(id);
        }
    }
}
