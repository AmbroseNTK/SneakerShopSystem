using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using UserService.Models;

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

        public override Task<GetNumOfUserReply> GetNumOfUser(GetNumOfUserRequest request, ServerCallContext context)
        {
            _context.Users.Load();
            var result = new GetNumOfUserReply();
            result.Total = _context.Users.Count();
            return Task.FromResult(result);
        }

        public override Task<GetUserByIdReply> GetUserById(GetUserByIdRequest request, ServerCallContext context)
        {
            _context.Users.Load();
            var user = (from u in _context.Users
                        where u.Id == request.Id
                        select new UserData { Id = u.Id, Name = u.Name, Role = u.Role }).SingleOrDefault();
            var result = new GetUserByIdReply { Data = user };
            return Task.FromResult(result);
        }

        public override Task<UpdateUserReply> UpdateUser(UpdateUserRequest request, ServerCallContext context)
        {
            _context.Users.Load();
            var user = (from u in _context.Users
                        where u.Id == request.Data.Id
                        select new Models.User { Id = u.Id, Name = u.Name, Role = u.Role }).SingleOrDefault();
            if(user == null)
            {
                return Task.FromResult(new UpdateUserReply { IsSuccess = false });
            }
            else
            {
                /*user.Id = request.Data.Id;*/
                user.Name = request.Data.Name;
                user.Role = request.Data.Role;
                _context.Users.Update(user);
            }
            _context.SaveChanges();
            return Task.FromResult(new UpdateUserReply { IsSuccess=true });
        }

        public override Task<DeleteUserReply> DeleteUser(DeleteUserRequest request, ServerCallContext context)
        {
            _context.Users.Load();
            var user = (from u in _context.Users
                        where u.Id == request.Id
                        select new Models.User { Id = u.Id, Name = u.Name, Role = u.Role }).SingleOrDefault();
            if (user == null)
            {
                return Task.FromResult(new DeleteUserReply { IsSuccess = false });
            }
            else
            {
                _context.Users.Remove(user);
            }
            _context.SaveChanges();
            return Task.FromResult(new DeleteUserReply { IsSuccess = true });
        }


    }
}