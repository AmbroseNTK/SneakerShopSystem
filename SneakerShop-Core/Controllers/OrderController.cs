using Microsoft.AspNetCore.Mvc;
using SneakerShop_Core.Models;

namespace SneakerShop_Core.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class OrderController : ControllerBase
    {
        private OrderService.Order.OrderClient _orderClient;

        public OrderController(OrderService.Order.OrderClient orderClient)
        {
            this._orderClient = orderClient;
        }

        [HttpPost]
        public async Task<OrderService.CreateOrderReply> Create(OrderRequest orderRequest)
        {
            var createdOrderRequest = new OrderService.CreateOrderRequest
            {
                OrderData = orderRequest.OrderData,

            };
            for (int i = 0; i < orderRequest.Details.Count; i++)
            {
                OrderService.OrderDetailData? detail = orderRequest.Details[i];
                createdOrderRequest.OrderDetailData.Add(detail);
            }
            var result = await _orderClient.AddOrderAsync(createdOrderRequest);
            return result;
        }

        [HttpGet("paginate")]
        public async Task<OrderService.GetOrderPaginateReply> GetOrderPaginate([FromQuery] long afterID, [FromQuery] int limit)
        {
            return await _orderClient.GetOrderPaginateAsync(new OrderService.GetOrderPaginateRequest { AfterID = afterID, Limit = limit });
        }

        [HttpGet("total")]
        public async Task<OrderService.GetNumOfOrderReply> GetNumOfOrder()
        {
            return await _orderClient.GetNumOfOrderAsync(new OrderService.GetNumOfOrderRequest { Message = "" });
        }

        [HttpGet("search")]
        public async Task<OrderService.GetOrderByIdReply> GetOrderById([FromQuery] long id)
        {
            return await _orderClient.GetOrderByIdAsync(new OrderService.GetOrderByIdRequest { Id = id });
        }

     
        [HttpDelete("delete")]
        public async Task<OrderService.DeleteOrderReply> DeleteOrder([FromQuery] long id)
        {
            var result = await _orderClient.DeleteOrderAsync(new OrderService.DeleteOrderRequest { Id = id });
            return result;
        }
    }
}
