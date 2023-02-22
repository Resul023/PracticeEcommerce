﻿
namespace ECommerceAPI.Application.Common.DTOs.Products;
public class ProductGetDto : IMapFrom<Product>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }

}
