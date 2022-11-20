using System;
using System.Collections.Generic;

namespace InvoiceService.Models;

public partial class Invoice
{
    public long Id { get; set; }

    public long OrderId { get; set; }

    public long CreatedAt { get; set; }
}
