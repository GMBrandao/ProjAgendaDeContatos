using ProjAgendaDeContatos;
List<Contacts> phonebook = new List<Contacts>();


Contacts contact = new("Jose", "987654321", "mail@example.com");
contact.Address.EditStreet("Rua Nove de Julho, 2100");
contact.Address.EditPostalCode("13562-458");
contact.Address.EditState("São Paulo");
contact.Address.EditCity("Bueno de Andrada");
contact.Address.EditCountry("Brasil");


Contacts contact2 = new("Pedro", "987654321", "mail@example.com");
contact2.Address.EditStreet("Rua 7 de Setembro, 333");
contact2.Address.EditPostalCode("12665-481");
contact2.Address.EditState("Pará");
contact2.Address.EditCity("Belém");
contact2.Address.EditCountry("Brasil");

Contacts contact3 = new("Joaquim", "549842154");

phonebook.Add(contact);
phonebook.Add(contact2);
phonebook.Add(contact3);
PrintPhoneBook(phonebook);

phonebook.Remove(contact2);
PrintPhoneBook(phonebook);

void PrintPhoneBook(List<Contacts> l)
{
    foreach(var item in l)
    {
        Console.WriteLine(item);
    }    
}