using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySalesMVC.Models
{
    public class Telephone
    {

        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }

        public Telephone()
        {

        }

        public Telephone(int id, string countryCode, string areaCode, string number)
        {
            Id = id;
            CountryCode = countryCode;
            AreaCode = areaCode;
            Number = number;
        }
    }
}
