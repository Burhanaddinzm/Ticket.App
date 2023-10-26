
using Ticket.Service.Services.Implementations;

TicketModelService ticketModelService = new TicketModelService();
ShowMenu();
string request = Console.ReadLine();
while (request != "0")
{
    switch (request)
    {
        case "1":
            ticketModelService.Create();
            break;
        case "2":
            ticketModelService.GetAll();
            break;
        case "3":
            ticketModelService.Get();
            break;
        case "4":
            ticketModelService.Remove();
            break;
        case "5":
            ticketModelService.Update();
            break;
        default:
            Console.WriteLine("Wrong Input");
            break;
    }
    ShowMenu();
    request = Console.ReadLine();
}
void ShowMenu()
{
    Console.WriteLine("1.Create");
    Console.WriteLine("2.GetAll");
    Console.WriteLine("3.Get");
    Console.WriteLine("4.Remove");
    Console.WriteLine("5.Update");
    Console.WriteLine("0.Close");
}