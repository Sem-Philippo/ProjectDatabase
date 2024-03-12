using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int Stock { get; set; }
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
        
    }
}
