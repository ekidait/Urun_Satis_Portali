﻿using Ekidait.Core.Entities;

namespace Ekidait.Service.Abstract
{
    public interface ICartService
    {
        void AddProduct(Product product, int quantity);
        void UpdateProduct(Product product, int quantity);
        void RemoveProduct(Product product);
        decimal TotalPrice();
        void ClearAll();
    }
}