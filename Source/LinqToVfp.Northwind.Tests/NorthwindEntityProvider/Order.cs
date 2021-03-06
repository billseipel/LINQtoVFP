/*
 * LINQ to VFP 
 * https://github.com/tombrothers/LINQtoVFP
 * http://www.randomdevnotes.com/tag/linq-to-vfp/
 * 
 * Written by Tom Brothers (TomBrothers@Outlook.com)
 * 
 * Released to the public domain, use at your own risk!
 */
using System;
using System.Collections.Generic;

namespace LinqToVfp.Northwind.Tests.NorthwindEntityProvider {
    public partial class Order {
        public string CustomerID { get; set; }
        public decimal Freight { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public string ShipCountry { get; set; }
        public Customer Customer { get; set; }				
        public List<OrderDetail> Details { get; set; }
    }
}