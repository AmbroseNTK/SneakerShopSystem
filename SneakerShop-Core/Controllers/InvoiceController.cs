using Microsoft.AspNetCore.Mvc;
using static InvoiceService.Invoice;

namespace SneakerShop_Core.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class InvoiceController : Controller
    {
        private InvoiceService.Invoice.InvoiceClient _invoiceClient;

        public InvoiceController(InvoiceService.Invoice.InvoiceClient invoiceClient)
        {
            this._invoiceClient = invoiceClient;
        }

        [HttpPost]
        public async Task<InvoiceService.CreateInvoiceReply> Create(InvoiceService.CreateInvoiceRequest createInvoiceRequest)
        {
            var result = await _invoiceClient.AddInvoiceAsync(createInvoiceRequest);
            return result;
        }

        [HttpGet("paginate")]
        public async Task<InvoiceService.GetInvoicePaginateReply> GetInvoicePaginate([FromQuery] long afterID, [FromQuery] int limit)
        {
            return await _invoiceClient.GetInvoicePaginateAsync(new InvoiceService.GetInvoicePaginateRequest { AfterID = afterID, Limit = limit });
        }

        [HttpGet("total")]
        public async Task<InvoiceService.GetNumOfInvoiceReply> GetNumOfInvoice()
        {
            return await _invoiceClient.GetNumOfInvoiceAsync(new InvoiceService.GetNumOfInvoiceRequest { Message = "" });
        }

        [HttpGet("search")]
        public async Task<InvoiceService.GetInvoiceByIdReply> GetInvoiceById([FromQuery] long id)
        {
            return await _invoiceClient.GetInvoiceByIdAsync(new InvoiceService.GetInvoiceByIdRequest { Id = id });
        }

        [HttpDelete("delete")]
        public async Task<InvoiceService.DeleteInvoiceReply> DeleteInvoice([FromQuery] long id)
        {
            var result = await _invoiceClient.DeleteInvoiceAsync(new InvoiceService.DeleteInvoiceRequest { Id = id });
            return result;
        }

    }
}
