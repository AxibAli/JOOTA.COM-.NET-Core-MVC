﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joota.com.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        
        public int Amount { get; set; }

        public double Price { get; set; }

        public int ShoeId { get; set; }
       [ ForeignKey ("ShoeId")]

        public  Shoes Shoes { get; set; }      
        
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]

        public Order Order { get; set; }

    }
}