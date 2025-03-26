using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FEMM20250326.AppWebMVC.Models;

public partial class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del producto es obligatorio")]
    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    [Required(ErrorMessage = "El precio del producto es obligatorio")]
    public decimal Price { get; set; }

    public int? WarehouseId { get; set; }

    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
