﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class ServiceInBill
    {
        public int ServiceInCinemaId { get; set; }
        public int BillId { get; set; }
        public int? Quantity { get; set; }
        public bool? Checking { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual ServiceInCinema ServiceInCinema { get; set; }
    }
}