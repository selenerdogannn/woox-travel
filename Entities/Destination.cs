using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2WooxTravel.Entities
{
    //denemeeeeee
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Title { get; set; }
        public string  Country { get; set; }
        public string City { get; set; }
        public int DayNight { get; set; }

        public string ImageUrl {  get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

    }
}