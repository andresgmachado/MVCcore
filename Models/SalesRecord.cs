using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public Double Amout { get; set; }
        public SaleStatus SalesStatus { get; set; }
        public Seller seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amout, SaleStatus salesStatus, Seller seller)
        {
            this.id = id;
            Date = date;
            Amout = amout;
            SalesStatus = salesStatus;
            this.seller = seller;
        }
    }
}
