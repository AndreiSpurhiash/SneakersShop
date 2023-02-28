﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakersShop.ApplicationCore.Entities
{
    public class Color : Entity
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The length of the Color Name should be from 3 to 50 characters")]
        [RegularExpression(@"[A-Za-z0-9]", ErrorMessage = "The Name is't correct!")]
        public string? Name { get; set; }
        public Color()
        {

        }
        public Color(string name)
        {
            Name = name;
        }
    }
}
