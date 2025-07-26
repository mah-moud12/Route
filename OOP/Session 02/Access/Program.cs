using Demo_02.Encapsulation;
namespace Access
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetName("Mostafa");
            emp.SetId(200);
            Console.WriteLine(emp);
        }
    }
}
