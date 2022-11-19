using Grpc.Core;
using UserService;

namespace UserService.Services
{
    public class UserService : User.UserBase
    {
        private readonly ILogger<UserService> _logger;
        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        public override Task<CreateUserReply> AddUser(CreateUserRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CreateUserReply
            {
                Message = "Created"
            });
        }

    }
}