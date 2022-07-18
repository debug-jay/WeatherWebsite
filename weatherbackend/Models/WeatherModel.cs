using System;

namespace weatherbackend.Models;

public class WeatherModel
{
   public class coord
   {
        public double lon { get; set; }
        public double lat { get; set; }
   }

   public class weather
   {
        public string? description { get; set; }
   }

   public class main
   {
        public double temp { get; set; }
   }

   public class sys
   {
        public string? country { get; set; }
   } 

   public class root
   {
        public coord? coord { get; set; }
        public List<weather>? weather { get; set; }
        public main? main { get; set; }
        public sys? sys { get; set; }
        public string? name { get; set; }
   }
}