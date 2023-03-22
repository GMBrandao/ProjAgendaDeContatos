using System.Runtime.InteropServices;
using ProjAgendaDeContatos;
List<Contacts> phonebook = new List<Contacts>();

string op;

do{
    Console.Clear();
    op = Menu();
    switch (op)
    {
        case "1":
            phonebook.Add(CreateContact());
            break;
        case "2":
            phonebook.

            break;
        case "3":
            phonebook.Remove(DeleteContact());
            break;
        case "4":
            PrintPhoneBook(phonebook);
            break;
        case "5":
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }

} while (true) ;

Contacts DeleteContact()
{
    Console.WriteLine("Infomre o nome que deseja remover?");
    string n = Console.ReadLine();
    foreach(var item in phonebook)
    {
        if(item.Name.Equals(n))
        {
            return item;
        }
    }
    return null;
}

Contacts CreateContact()
{
    Console.WriteLine("Informe o nome: ");
    string n = Console.ReadLine();
    Console.WriteLine("Informe o telefone: ");
    var t = Console.ReadLine();
    Contacts contact = new(n, t);
    return contact;
}

void PrintPhoneBook(List<Contacts> l)
{
    foreach(var item in l)
    {
        Console.WriteLine(item);
    }
    Console.ReadLine();
}

string Menu()
{
    Console.WriteLine($">>>>> MENU DE OPÇÕES <<<<<\n1 - Inserir Contato\n2 - Editar Contato\n3 - Remover Contato\n4 - Mostrar agenda" +
        $"\n5 - Sair\nEscolha uma opção:");

    return Console.ReadLine();
}