﻿using ComiAPI.Helpers;
using ComiCore;
using ComiCore.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ComiAPI.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(IOptions<AppSettings> appSettings, ApplicationDbContext context, 
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _appSettings = appSettings.Value;
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public ApplicationUser Authenticate(string email, string password)
        {
            var user = _userManager.FindByEmailAsync(email).Result;
            if (_userManager.CheckPasswordAsync(user, password).Result == false)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user;
        }

        public async Task<ApplicationUser> CreateAsync(string email, string password)
        {
            if (_userManager.FindByEmailAsync(email).Result != null)
                return null;
            var user = new ApplicationUser { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);
            
            await _userManager.AddToRoleAsync(user, Enum.GetName(typeof(Role), 4));
            if (!result.Succeeded)
                return null;
            return user;
        }


        public IEnumerable<ApplicationUser> GetAll()
        {
            return _context.Users.ToList();
        }

        public ApplicationUser GetById(string id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public ApplicationUser GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }

        //private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        //{
        //    if (password == null) throw new ArgumentNullException("password");
        //    if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

        //    using (var hmac = new System.Security.Cryptography.HMACSHA512())
        //    {
        //        passwordSalt = hmac.Key;
        //        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        //    }
        //}

        //private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        //{
        //    if (password == null) throw new ArgumentNullException("password");
        //    if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
        //    if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
        //    if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

        //    using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
        //    {
        //        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        //        for (int i = 0; i < computedHash.Length; i++)
        //        {
        //            if (computedHash[i] != storedHash[i]) return false;
        //        }
        //    }

        //    return true;
        //}
    }
}
