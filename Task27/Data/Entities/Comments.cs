using System;
using System.Collections.Generic;
using System.Text;

namespace Task27.Data.Entities
{
    public class CommentsEntity
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public UserEntity User { get; set; }
        public ProductEntity Product { get; set; }
    }
}
