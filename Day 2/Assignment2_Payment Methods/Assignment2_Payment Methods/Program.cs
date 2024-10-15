namespace Assignment2_Payment_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment payment;
            string paymentMethod = Console.ReadLine().Trim().ToLower();
            switch (paymentMethod) 
            {
                case "paypal":
                    payment = new PayPal();
                    break;
                case "credit":
                    payment = new CreditCardPayment();
                    break;
                case "banktransfer":
                    payment = new BankTransfer();
                    break;
                default:
                    Console.WriteLine("Invalid Payment Method");
                    return;
            }
            Console.Write("enter the amount to pay: ");
            double amount = double.Parse(Console.ReadLine());
            payment.Pay(amount);
        }
    }
}
