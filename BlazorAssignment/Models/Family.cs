﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BlazorAssignment.Models
{

    public class Family
        {

            //public int Id { get; set; }
            [Required]
            public string StreetName { get; set; }
            [Required]
            public int HouseNumber { get; set; }
            public List<Adult> Adults { get; set; }
            public List<Child> Children { get; set; }
            public List<Pet> Pets { get; set; }
        public int Id { get; internal set; }

        public Family()
            {
                Adults = new List<Adult>();
            }

        }


    }
