using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using UserService;
using UserService.Models;
using System.Linq;

namespace UserService.Services
{
    public class UserService : User.UserBase
    {
        private readonly UserContext _context;
        private readonly ILogger<UserService> _logger;
        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
            _context = new UserContext();
        }

        public override Task<CreateUserReply> AddUser(CreateUserRequest request, ServerCallContext context)
        {
            _context.Users.Add(new Models.User()
            {
                Name = request.Data.Name,
                Role = request.Data.Role,
            });
            _context.SaveChanges();
            return Task.FromResult(new CreateUserReply
            {
                Message = "Created"
            });
        }

        public override Task<GetUserPaginateReply> GetUserPaginate(GetUserPaginateRequest request, ServerCallContext context)
        {
            _context.Users.Load();
            var users = (from user in _context.Users
                         where user.Id > request.AfterID
                         select new UserData { Id = user.Id, Name = user.Name, Role = user.Role }).Take(request.Limit);
            var result = new GetUserPaginateReply();
            foreach (var user in users)
            {
                result.UserList.Add(user);
            }
            return Task.FromResult(result);
           
        }


    }
}