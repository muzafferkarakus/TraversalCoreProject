﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; } 
        public string City { get; set; } 
        public string DayNight { get; set; } 
        public double Price { get; set; } 
        public string Image { get; set; } 
        public string Description { get; set; } 
        public int Capacity { get; set; } 
        public string Status { get; set; }
        public string CoverPhoto { get; set; }
        public string Details { get; set; }
        public string Details2 { get; set; }
        public string Image2 { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
