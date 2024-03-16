IBanking banking = new ATM();
Customer _customer = new Customer();

Console.WriteLine("Digite el tipo de canal: ");
int canal = Convert.ToInt32(Console.ReadLine());

switch (canal){
    case 1:
    banking = new ATM();
    break;
    case 2:
    banking = new IB();
    break;
    default:
    Console.WriteLine("Canal invalido");
    break;
}

Console.WriteLine("Digite el Monto:");
_customer.monto = Convert.ToDecimal(Console.ReadLine());
banking.Deposit(_customer);