using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgendaDeContatos
{
    internal class Contacts
    {
        public string Name { get; set; }
        public Address? Address { get; set; }
        public string Phone { get; set;}
        public string? Email { get; set;}

        public Contacts(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = new();
            this.Email = "";
        }
        public Contacts(string name, string phone, string email) 
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Address = new();
        }
        public Contacts(string name, Address address, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Email = "";
        }
        public Contacts(string name, Address address, string phone, string email)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
        }

        public void EditPhone(string p)
        {
            this.Phone = p;
        }

        public void EditEmail(string e)
        {
            this.Email = e;
        }

        public override string ToString()
        {
            if (this.Address.ToString().Equals("") && this.Email == "")
            {
                return "\nNome: " + Name + "\nTelefone: " + Phone + "\n";
            }
            else if (this.Email == "")
            {
                return "\nNome: " + Name + "\nEndereço: " + Address + "\nTelefone: " + Phone + "\n";
            }
            else if(this.Address.ToString().Equals(""))
            {
                return "\nNome: " + Name + "\nTelefone: " + Phone + "\nEmail: " + Email + "\n";
            }
            else 
            {
                return "\nNome: " + Name + "\nTelefone: " + Phone + "\nEmail: " + Email+ "\nEndereço: " + Address + "\n"; 
            }
        }
    }
}
