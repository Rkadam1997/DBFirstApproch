using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class Category
{
    public byte CategoryId { get; set; }

    public string CategoryName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
