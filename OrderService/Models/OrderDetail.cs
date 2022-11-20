using System;
using System.Collections.Generic;

namespace OrderService.Models;

public partial class OrderDetail
{
    public long Id { get; set; }

    public long OderId { get; set; }

    public long ProdId { get; set; }

    public byte[] Quantity { get; set; } = null!;
}
