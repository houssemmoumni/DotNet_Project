using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        String BirthDate { get; set; }
        String PassportNumber { get; set; }
        String EmailAdress { get; set; }
        String FirstName { get; set; }
        String LasName { get; set; }
        int TelNumber { get; set; }

        public ICollection<Flight> Flights { get; set; }
       
    }

}
