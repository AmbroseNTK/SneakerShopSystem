// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/user.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace UserService {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class User
  {
    static readonly string __ServiceName = "user.User";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.CreateUserRequest> __Marshaller_user_CreateUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.CreateUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.CreateUserReply> __Marshaller_user_CreateUserReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.CreateUserReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.GetNumOfUserRequest> __Marshaller_user_GetNumOfUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.GetNumOfUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.GetNumOfUserReply> __Marshaller_user_GetNumOfUserReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.GetNumOfUserReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.GetUserByIdRequest> __Marshaller_user_GetUserByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.GetUserByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.GetUserByIdReply> __Marshaller_user_GetUserByIdReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.GetUserByIdReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.GetUserPaginateRequest> __Marshaller_user_GetUserPaginateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.GetUserPaginateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.GetUserPaginateReply> __Marshaller_user_GetUserPaginateReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.GetUserPaginateReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.UpdateUserRequest> __Marshaller_user_UpdateUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.UpdateUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.UpdateUserReply> __Marshaller_user_UpdateUserReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.UpdateUserReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.DeleteUserRequest> __Marshaller_user_DeleteUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.DeleteUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.DeleteUserReply> __Marshaller_user_DeleteUserReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.DeleteUserReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserService.CreateUserRequest, global::UserService.CreateUserReply> __Method_AddUser = new grpc::Method<global::UserService.CreateUserRequest, global::UserService.CreateUserReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddUser",
        __Marshaller_user_CreateUserRequest,
        __Marshaller_user_CreateUserReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserService.GetNumOfUserRequest, global::UserService.GetNumOfUserReply> __Method_GetNumOfUser = new grpc::Method<global::UserService.GetNumOfUserRequest, global::UserService.GetNumOfUserReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetNumOfUser",
        __Marshaller_user_GetNumOfUserRequest,
        __Marshaller_user_GetNumOfUserReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserService.GetUserByIdRequest, global::UserService.GetUserByIdReply> __Method_GetUserById = new grpc::Method<global::UserService.GetUserByIdRequest, global::UserService.GetUserByIdReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserById",
        __Marshaller_user_GetUserByIdRequest,
        __Marshaller_user_GetUserByIdReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserService.GetUserPaginateRequest, global::UserService.GetUserPaginateReply> __Method_GetUserPaginate = new grpc::Method<global::UserService.GetUserPaginateRequest, global::UserService.GetUserPaginateReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserPaginate",
        __Marshaller_user_GetUserPaginateRequest,
        __Marshaller_user_GetUserPaginateReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserService.UpdateUserRequest, global::UserService.UpdateUserReply> __Method_UpdateUser = new grpc::Method<global::UserService.UpdateUserRequest, global::UserService.UpdateUserReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateUser",
        __Marshaller_user_UpdateUserRequest,
        __Marshaller_user_UpdateUserReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserService.DeleteUserRequest, global::UserService.DeleteUserReply> __Method_DeleteUser = new grpc::Method<global::UserService.DeleteUserRequest, global::UserService.DeleteUserReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteUser",
        __Marshaller_user_DeleteUserRequest,
        __Marshaller_user_DeleteUserReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::UserService.UserReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of User</summary>
    [grpc::BindServiceMethod(typeof(User), "BindService")]
    public abstract partial class UserBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserService.CreateUserReply> AddUser(global::UserService.CreateUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserService.GetNumOfUserReply> GetNumOfUser(global::UserService.GetNumOfUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserService.GetUserByIdReply> GetUserById(global::UserService.GetUserByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserService.GetUserPaginateReply> GetUserPaginate(global::UserService.GetUserPaginateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserService.UpdateUserReply> UpdateUser(global::UserService.UpdateUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserService.DeleteUserReply> DeleteUser(global::UserService.DeleteUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(UserBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddUser, serviceImpl.AddUser)
          .AddMethod(__Method_GetNumOfUser, serviceImpl.GetNumOfUser)
          .AddMethod(__Method_GetUserById, serviceImpl.GetUserById)
          .AddMethod(__Method_GetUserPaginate, serviceImpl.GetUserPaginate)
          .AddMethod(__Method_UpdateUser, serviceImpl.UpdateUser)
          .AddMethod(__Method_DeleteUser, serviceImpl.DeleteUser).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UserBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserService.CreateUserRequest, global::UserService.CreateUserReply>(serviceImpl.AddUser));
      serviceBinder.AddMethod(__Method_GetNumOfUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserService.GetNumOfUserRequest, global::UserService.GetNumOfUserReply>(serviceImpl.GetNumOfUser));
      serviceBinder.AddMethod(__Method_GetUserById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserService.GetUserByIdRequest, global::UserService.GetUserByIdReply>(serviceImpl.GetUserById));
      serviceBinder.AddMethod(__Method_GetUserPaginate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserService.GetUserPaginateRequest, global::UserService.GetUserPaginateReply>(serviceImpl.GetUserPaginate));
      serviceBinder.AddMethod(__Method_UpdateUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserService.UpdateUserRequest, global::UserService.UpdateUserReply>(serviceImpl.UpdateUser));
      serviceBinder.AddMethod(__Method_DeleteUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserService.DeleteUserRequest, global::UserService.DeleteUserReply>(serviceImpl.DeleteUser));
    }

  }
}
#endregion
