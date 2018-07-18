﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Prepaid : BaseEntity
    {
        public int Id_Prepaid { get; set; }
        public int Id_Product { get; set; }
        public int Prepaid_Quantity { get; set; }
        public decimal Prepaid_Total { get; set; }
        public decimal Prepaid_Cash { get; set; }
        public decimal Prepaid_Change { get; set; }
        public int Prepaid_Balance { get; set; }
        /// <foreigner> variables for esthetic query of UI
        public string Name_Product { get; set; }
        /// </foreigner>
        /// Default Constructor
        public Prepaid()
        {
            Id_Prepaid = 0;
            Id_Product = 0;
            Prepaid_Quantity = 0;
            Prepaid_Total = 0;
            Prepaid_Cash = 0;
            Prepaid_Change = 0;
            Prepaid_Balance = 0;
        }
        /// Constructor With parameters of DB
        public Prepaid(int pId_Prepaid, int pId_Product, int pPrepaid_Quantity, decimal pPrepaid_Total, decimal pPrepaid_Cash,
            decimal pPrepaid_Change, int Prepaid_Balance, bool? pState, string pCreateBy, 
            string pUpdateBy, DateTime pCreateDate,
            DateTime? pUpdateDate)
        {
            Id_Prepaid = pId_Prepaid;
            Id_Product = pId_Product;
            Prepaid_Quantity = pPrepaid_Quantity;
            Prepaid_Total = pPrepaid_Total;
            Prepaid_Cash = pPrepaid_Cash;
            Prepaid_Change = 0;
            Prepaid_Balance = 0;
        }
        /// Constructor With parameters of DB and esthetic
        public Prepaid(int pId_Prepaid, string pName_Product, int pPrepaid_Quantity, decimal pPrepaid_Total, decimal pPrepaid_Cash,
            decimal pPrepaid_Change, int Prepaid_Balance, bool? pState, string pCreateBy,
            string pUpdateBy, DateTime pCreateDate,
            DateTime? pUpdateDate)
        {
            Id_Prepaid = 0;
            Id_Product = 0;
            Prepaid_Quantity = 0;
            Prepaid_Total = 0;
            Prepaid_Cash = 0;
            Prepaid_Change = 0;
            Prepaid_Balance = 0;
        }
    }
}
