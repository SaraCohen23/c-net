

using BlApi;
using System.ComponentModel;

namespace BlTest;

internal class Program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
    static void Main(string[] args)
    {
        string add;int x;
       
        do
        {
            Console.WriteLine("insert user id or 0 if you are new user");
            int id = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("insert product id and quantity");
                int pId = int.Parse(Console.ReadLine());
                int quantity = int.Parse(Console.ReadLine());

                //ליצור הזמנה להציג מבצעים ולחשב מחיר
                Console.WriteLine("Do you want to add product? \n press yes else press exit");
                add = Console.ReadLine();
            } while (add=="yes");
            Console.WriteLine("do you want to continue?press 0 else press 1");
            x = int.Parse(Console.ReadLine());
        } while (x==0);



    }
}
