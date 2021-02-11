using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Josiah_Sarles.Models
{
    public class Restaurant
    {

        [Required]
        public int rank { get; set;}

        [Required]
        public string name { get; set; }

        public string favdish { get; set; }

        [Required]
        public string address { get; set; }

        [Phone]
        public string phone { get; set; }

        public string website { get; set; }


        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant
            {
                rank = 1,
                name = "Cubbys",
                favdish = "Big Dog Tri Tip Sandwich",
                address = "Cougar Blvd",
                phone = "",
                website = ""

        };

        
            return new Restaurant[] { null };
        }

    }
}
