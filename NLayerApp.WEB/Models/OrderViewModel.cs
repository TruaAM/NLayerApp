﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerApp.WEB.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public string Name { get; set; } // Пока вместо отдельной таблицы UsersDetails
        public string Surname { get; set; } // Пока вместо отдельной таблицы UsersDetails
        public string PhoneNumber { get; set; } // Пока вместо отдельной таблицы UsersDetails
        public string City { get; set; } // Пока вместо отдельной таблицы UsersDetails
        public string PostIndex { get; set; } // Пока вместо отдельной таблицы UsersDetails

        public int ProductId { get; set; }
    }
}
