using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        private const int sufficientStock = 10;
        public int StockAmount { get; set; }
        public Stock StockGrade
        {
            get
            {
                if (StockAmount >= sufficientStock)
                {
                    return Stock.Sufficient;
                }
                else if (StockAmount > 0)
                {
                    return Stock.Nearly_Depleted;
                }
                else
                {
                    return Stock.Empty;
                }
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Alcoholic { get; set; }
        public float Price { get; set; }
        public float VAT 
        { 
            get
            {
                if (Alcoholic)
                {
                    return Price *= 1.21f;
                }
                else 
                { 
                    return Price *= 1.09f; 
                }
            } 
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
