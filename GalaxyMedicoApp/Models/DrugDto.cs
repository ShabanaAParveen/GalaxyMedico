﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedicoApp.Models
{
    public class DrugDto
    {
        public DrugDto()
        {
            Count = 1;
        }
        public int DrugId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        [Range(1,100)]
        public int Count { get; set; }
    }
}
