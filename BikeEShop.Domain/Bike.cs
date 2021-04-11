using System;
using System.Collections.Generic;
using System.Text;

namespace BikeEShop.Domain
{
    public class Bike
    {
        public int BikeId { get; set; }
        public string BikeModel { get; set; }
        public int? ProductionYear { get; set; }
        public decimal Price { get; set; }
    }
}
