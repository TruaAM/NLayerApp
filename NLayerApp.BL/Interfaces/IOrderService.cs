using NLayerApp.BL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerApp.BL.Interfaces
{
    public interface IOrderService
    {
        void MakeOrder(OrderDTO orderDto);
        ProductDTO GetProduct(int? id);
        IEnumerable<ProductDTO> GetProducts();
        void Dispose();
    }
}
