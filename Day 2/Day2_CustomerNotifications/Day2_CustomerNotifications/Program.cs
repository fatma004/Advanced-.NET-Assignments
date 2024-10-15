namespace Day2_CustomerNotifications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerNotification customerNotification = new CustomerNotification();
            customerNotification.SendNotification(new EmailNotification(), "please call me!");
        }
    }
}
