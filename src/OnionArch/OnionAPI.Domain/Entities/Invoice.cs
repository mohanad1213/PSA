using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Domain.Entities
{
    public class Invoice
    {
        public Invoice(string to, DateTime invoiceDate)
        {

        }

        private int id;
        private string to;
        private DateTime invoiceDate;
        private List<Product> productList;
        private decimal totalPrice = 0;
        private decimal discount;



        public decimal TotalPrice
        {
            get { return totalPrice; }
        }



        public decimal Discount
        {
            get
            { return Discount; }
            set
            { this.discount = value; }
        }



        public void AddProduct(Product product)
        {
            this.productList.Add(product);
            this.totalPrice += product.Price;
        }


        public void RemoveProduct(int invoiceProductId)
        {

        }


    }
}
