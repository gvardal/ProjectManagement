using AuthServer.Core.Dtos;
using AuthServer.Core.Models;
using AuthServer.Core.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using SharedLibrary.Dtos;
using System.Runtime.Intrinsics.X86;

namespace AuthServer.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<UserApp> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService(UserManager<UserApp> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new UserApp()
            {
                Email = createUserDto.Email,
                UserName = createUserDto.UserName
            };
            var result = await _userManager.CreateAsync(user, createUserDto.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();
                return Response<UserAppDto>.Fail(new ErrorDto(errors, true), 400);
            }
            return Response<UserAppDto>.Success(ObjectMapper.Mapper.Map<UserAppDto>(user), 200);
        }

        public async Task<Response<NoContent>> CreateUserRoles(string userName)
        {
            if (!await _roleManager.RoleExistsAsync("admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "admin" });
                await _roleManager.CreateAsync(new IdentityRole { Name = "manager" });
            }
            var user = await _userManager.FindByNameAsync(userName);
            if (user is not null)
            {
                //await _userManager.AddToRoleAsync(user, "admin");
            }
            return Response<NoContent>.Success(201);
        }

        public async Task<Response<UserAppDto>> GetUserByNameAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user is null) return Response<UserAppDto>.Fail("Username not found", 404, true);
            return Response<UserAppDto>.Success(ObjectMapper.Mapper.Map<UserAppDto>(user), 200);
        }
    }
}
