using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgendaDeContatos
{
    internal class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public Address()
        {
            
        }

        public void EditStreet(string s)
        {
            this.Street = s;
        }
        public void EditState(string st)
        {
            this.State = st;
        }
        public void EditCity(string c)
        {
            this.City = c;
        }
        public void EditCountry(string c)
        {
            this.Country = c;
        }
        public void EditPostalCode(string ps)
        {
            this.PostalCode = ps;
        }

        public override string ToString()
        {
            if(Street == null && City == null && State == null && PostalCode == null)
            {
                return "";
            }
            return $"{Street} - {City} - {State} - {PostalCode} - {Country}";
        }
    }
}
