using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Josiah_Sarles.Models
{
    public class AddRestaurant
    {
        [Required(ErrorMessage = "Please enter a rank")]
        public string rank { get; set; }

        [Required(ErrorMessage = "Please enter the restaurant name")]
        public string name { get; set; }

        public string favdish { get; set; }

        [Phone]
        public string phone { get; set; }

    }
}
