namespace Day2_VehicleControlSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.Start();
            v.Describe();
        }
    }
}
