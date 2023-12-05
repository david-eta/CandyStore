﻿using CSharpestServer.Models;
using CSharpestServer.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CSharpestServer.Services
{
    public class UsersService : IUsersService
    {
        private readonly StoreContext _storeContext;

        public UsersService(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }
        private User GetInitialisedId(User user)
        {
            if (user.Id == Guid.Empty) { user.Id = Guid.NewGuid(); }

            return user;
        }
        public Task AddAsync(User user)
        {
            try
            {
                user = GetInitialisedId(user);
                user.CartId = user.Id;
                _storeContext.users.Add(user);
                _storeContext.SaveChanges();

                Cart cart = new Cart(user);
                _storeContext.carts.Add(cart);
                _storeContext.SaveChanges();

            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return Task.CompletedTask;
        }

        public Task Login(string email, string password)
        {
            var users = _storeContext.users.AsEnumerable();
            try
            {
                User found = _storeContext.users.Find(email);
                if (found.Password == password)
                {
                    return Task.CompletedTask;
                } else
                {
                    //wrong password
                    return Task.FromException(new NullReferenceException());
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public Task DeleteUser(Guid id)
        {
            try
            {
                var user = _storeContext.users.Find(id);
                _storeContext.users.Remove(user);
                _storeContext.SaveChanges();

            } catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }       

            return Task.CompletedTask;
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
                return Task.FromResult(_storeContext.users.AsEnumerable());
        }

        public Task<User?> GetByIdAsync(Guid id)
        {
            User? user = _storeContext.users.Find(id);
            return Task.FromResult(user);
        }

        public User? GetById(Guid id)
        {
            return _storeContext.users.Find(id);
        }

    }
}
