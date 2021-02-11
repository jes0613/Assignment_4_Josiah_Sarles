using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Josiah_Sarles.Models
{
    public class Restaurant
    {
        public Restaurant(int Rrank)
        {
            rank = Rrank;
        }

        [Required]
        public int rank { get;}

        [Required]
        public string name { get; set; }

        public string? favdish { get; set; } = "It\'s all tasty!";

        [Required]
        public string address { get; set; }

        [Phone]
        public string? phone { get; set; } = "";

        public string? website { get; set; } = "Coming soon.";


        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                name = "Cubby\'s",
                favdish = "Big Dog Tri Tip Sandwich",
                address = "Cougar Blvd",
                phone = "(801) 919-3023",
                website = "http://cubbys.co/"
            };

            Restaurant r2 = new Restaurant(2)
            {
                name = "Kneaders",
                favdish = "Turkey Bacon Avocado",
                address = "Cougar Blvd",
                phone = "(801) 812 - 2200",
                website = "https://www.kneaders.com/"
            };

            Restaurant r3 = new Restaurant(3)
            {
                name = "Texas Roadhouse",
                address = "State St",
                phone = ""
            };

            Restaurant r4 = new Restaurant(4)
            {
                name = "Wingers",
                address = "State St",
                phone = "(801) 812-2141"
            };

            Restaurant r5 = new Restaurant(5)
            {
                name = "Don Joaquin\'s",
                address = "Cougar Blvd",
                phone = "(801) 400-2894"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
