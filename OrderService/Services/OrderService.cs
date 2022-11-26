using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using OrderService;
using OrderService.Models;
using System.Collections.Generic;

namespace OrderService.Services
{
    public class OrderService : Order.OrderBase
    {
        private readonly ProductService.Product.ProductClient _productClient;
        private readonly OrderContext _context;
        private readonly ILogger<OrderService> _logger;
        public OrderService(ILogger<OrderService> logger,OrderContext context, ProductService.Product.ProductClient productClient )
        {
            _logger = logger;
            _context = context;
            _productClient = productClient;
        }

        public override Task<CreateOrderReply> AddOrder(CreateOrderRequest request, ServerCallContext context)
        {
            double total = 0;
            foreach (var orderDetail in request.OrderDetailData)
            {
                var prodPrice = _productClient.GetProductPrice(new ProductService.GetProductPriceRequest { Id = orderDetail.Id });
                total = (orderDetail.Quantity * prodPrice.Price) + total;
            }
            var order = new Models.Order()
            {
                UserId = request.OrderData.UserID,
                Total = total,
                CreatedAt = BitConverter.GetBytes(Convert.ToInt32(DateTime.Now))
            };
       
            foreach (var orderDetail in request.OrderDetailData)
            {
                order.OrderDetails.Add(new OrderDetail()
                {
                    OrderId = order.Id,
                    ProdId = orderDetail.ProdID,
                    Quantity = BitConverter.GetBytes(orderDetail.Quantity)
                });
            }

            _context.Orders.Add(order);
            _context.SaveChanges();
            return Task.FromResult(new CreateOrderReply
            {
                Message = "Created"
            });
        }

        public override Task<GetOrderPaginateReply> GetOrderPaginate(GetOrderPaginateRequest request, ServerCallContext context)
        {
            _context.Orders.Load();
            var orders = (from order in _context.Orders
                          where order.Id > request.AfterID
                          select new OrderData
                          {
                              Id = order.Id,
                          }).Take(request.Limit);
            var result = new GetOrderPaginateReply();
            foreach (var order in orders)
            {
                result.OrderList.Add(order);
            }
            return Task.FromResult(result);

        }

        public override Task<GetNumOfOrderReply> GetNumOfOrder(GetNumOfOrderRequest request, ServerCallContext context)
        {
            _context.Orders.Load();
            var result = new GetNumOfOrderReply();
            result.Total = _context.Orders.Count();
            return Task.FromResult(result);
        }

        public override Task<GetOrderByIdReply> GetOrderById(GetOrderByIdRequest request, ServerCallContext context)
        {
            
            var order = (from o in _context.Orders
                         where o.Id == request.Id
                         select o).SingleOrDefault();
            if(order != null)
            {
                _context.Entry(order).Collection(e => e.OrderDetails).Load();
                var result = new GetOrderByIdReply { OrderData = new OrderData {
                    Id = order.Id,
                    CreatedAt = BitConverter.ToInt32(order.CreatedAt,0),
                    UserID = order.UserId,
                    Total = order.Total
                } };
                foreach (var orderDetail in order.OrderDetails)
                {
                    result.OrderDetailData.Add(new OrderDetailData() { 
                        Id = orderDetail.Id,
                        OrderID = orderDetail.OrderId,
                        ProdID = orderDetail.ProdId,
                        Quantity = BitConverter.ToInt32(orderDetail.Quantity,0)
                    });
                } 
                return Task.FromResult(result);
            }
            return Task.FromResult(new GetOrderByIdReply { });
        }

        public override Task<DeleteOrderReply> DeleteOrder(DeleteOrderRequest request, ServerCallContext context)
        {
            var stock = (from s in _context.Orders
                         where s.Id == request.Id
                         select s).SingleOrDefault();
            if (stock == null)
            {
                return Task.FromResult(new DeleteOrderReply { IsSuccess = false });
            }
            else
            {
                _context.Orders.Remove(stock);
                _context.SaveChanges();
            }
            return Task.FromResult(new DeleteOrderReply { IsSuccess = true });
        }

    }
}