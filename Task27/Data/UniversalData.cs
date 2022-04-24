using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task27.Data.Entities;

namespace Task27.Data
{
    internal class UniversalData
    {
        Task27DBContext db = new Task27DBContext();
        public void AddProduct()
        {
            Console.WriteLine("Ad , Say ve qiymet yaz :");
            string name = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            ProductEntity product = new ProductEntity()
            {
                Name = name,
                Price = price,
                Count = count
            };
            db.Products.Add(product);
            db.SaveChanges();
        }
        public void ShowInfoFromProduct()
        {
            Console.WriteLine("Axtarmaq istediyiniz adi yazin : ");
            string str = Console.ReadLine();
            var data = db.Products.Where(x => x.Name.Contains(str)).ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Count + " " + item.Price);
            }
        }
        public void ShowCommentByProduct()
        {
            Console.WriteLine("Id ni yazin : ");
            int ID = int.Parse(Console.ReadLine());
            var data = db.Comment.Where(x => x.ProductID == ID).ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.Text);
            }
        }
        public void ShowCommentByUserID()
        {
            Console.WriteLine("Id ni yazin : ");
            int ID = int.Parse(Console.ReadLine());
            var data = db.Comment.Where(x => x.UserID == ID).ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.Text);
            }
        }
        public void DeleteCommontByID()
        {
            Console.WriteLine("ID ni daxil edin :");
            int ID = int.Parse(Console.ReadLine());
            var data = db.Comment.Where(x => x.ID == ID).FirstOrDefault();
            db.Comment.Remove(data);
            db.SaveChanges();
        }
        public void ShowAVGPrice() 
        {
            var data = db.Products.ToList();
            int sum = 0 , count = 0;
            foreach (var item in data)
            {
                sum += item.Price;
                count++;
            }
            Console.WriteLine(sum/count);
        }


    }
}
