using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
  public  class CartItems
    {
        public string ItemDesc { get; set; }
        public Double Amount { get; set; }
        public int Qty { get; set; }
        public Double  Discount { get; set; }
        public Double Total { get; set; }

        public CartItems(string itemDesc="",Double Amount=0.0,int Qty=0,Double Discount=0.0,Double Total=0.0)
        {
            this.ItemDesc = itemDesc;
            this.Amount = Amount;
            this.Qty = Qty;
            this.Discount = Discount;
            this.Total = Total;
           // Console.WriteLine( "{0},{1},{2},{3},{4}", ItemDesc,Amount,Qty,Discount,Total);
        }
    }
}
