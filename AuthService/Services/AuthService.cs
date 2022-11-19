using System;
using Grpc.Core;

namespace AuthService.Services
{
    public class AuthService : Auth.AuthBase
    {
        public override Task<LoginReply> Login(LoginRequest request, ServerCallContext context)
        {
            return base.Login(request, context);
        }

        public override Task<VerifyReply> Verify(VerifyRequest request, ServerCallContext context)
        {
            return base.Verify(request, context);
        }
    }
}

