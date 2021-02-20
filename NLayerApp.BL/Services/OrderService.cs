using System;
using NLayerApp.BL.DTO;
using NLayerApp.DAL.Models;
using NLayerApp.DAL.Interfaces;
using NLayerApp.BL.Infrastructure;
using NLayerApp.BL.Interfaces;
using System.Collections.Generic;
using AutoMapper;

namespace NLayerApp.BL.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork Database { get; set; }

        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void MakeOrder(OrderDTO orderDto)
        {
            Product product = Database.Products.Get(orderDto.ProductId);

            // валидация
            if (product == null)
                throw new ValidationException("Товар не найден", "");
            // применяем скидку
            //decimal sum = new Discount(0.1m).GetDiscountedPrice(product.Price);
            Order order = new Order
            {
                Date = DateTime.Now,
                City = orderDto.City, // Изменено с Address
                PostIndex = orderDto.PostIndex, // Добавлено
                ProductId = product.Id,
                Sum = product.Price, // Изменено с sum
                PhoneNumber = orderDto.PhoneNumber
            };
            Database.Orders.Create(order);
            Database.Save();
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Product>, List<ProductDTO>>(Database.Products.GetAll());
        }

        public ProductDTO GetProduct(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id товара", "");
            var product = Database.Products.Get(id.Value);
            if (product == null)
                throw new ValidationException("Товар не найден", "");

            return new ProductDTO { Description = product.Description, Id = product.Id, Name = product.Name, Price = product.Price };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
