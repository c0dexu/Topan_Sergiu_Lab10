using System;
using System.Collections.Generic;
using System.Text;
using SQLite;



namespace Topan_Sergiu_Lab10.Models
{
    class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
