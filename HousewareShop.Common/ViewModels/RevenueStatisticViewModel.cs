using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareShop.Common.ViewModels
{
    public class RevenueStatisticViewModel
    {
        public DateTime Date { set; get; }
        public string Name { set; get; }
        public int Quantitys { set; get; }
        public decimal Revenues { set; get; }
        public decimal Benefit { set; get; }
    }
}
