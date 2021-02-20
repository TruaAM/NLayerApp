using System;
using System.Collections.Generic;
using System.Text;
using NLayerApp.DAL.Data;

namespace NLayerApp.DAL.Models
{
	public class Order // Пока общая модель, заменяющая Orders и OrdersContents
                // Не учтена привязка к юзеру, статус заказа, кол-во товара
	{
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public string Name { get; set; } // Пока вместо отдельной таблицы UsersDetails
        public string Surname { get; set; } // Пока вместо отдельной таблицы UsersDetails
        public string PhoneNumber { get; set; } // Пока вместо отдельной таблицы UsersDetails
        public string City { get; set; } // Пока вместо отдельной таблицы UsersDetails
        public string PostIndex { get; set; } // Пока вместо отдельной таблицы UsersDetails

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public DateTime Date { get; set; }
    }
}
