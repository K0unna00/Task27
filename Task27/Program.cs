using System;
using Task27.Data;
using Task27.Data.Entities;

namespace Task27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task27DBContext db = new Task27DBContext();
            UniversalData UD = new UniversalData();
            bool check =true;
            while (check=true)
            {
                Console.WriteLine("1.Product elave et : \n2.Product uzre axtaris et : \n3.Secilmis Productun Commentlerine bax" +
                    "\n4.Secilmis Userin commentlerine bax : \n5. Comment sil : \n6. Productlarin AVG qiymetine bax : \n7.Quit"); 
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        UD.AddProduct();
                        break;
                    case 2:
                        UD.ShowInfoFromProduct();
                        break;
                    case 3:
                        UD.ShowCommentByProduct();
                        break;
                    case 4:
                        UD.ShowCommentByUserID();
                        break;
                    case 5:
                        UD.DeleteCommontByID();
                        break;
                    case 6:
                        UD.ShowAVGPrice();
                        break;
                    case 7:
                        check = false;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
