using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        public List<Product> order = new List<Product>();
        
        public void AddProduct(Product p)
        {
            order.Add(p); 
        }
        public double GetValueOfProducts()
        {
            double result = 0;
            int i = 0;
            while(order.Count > i)
            {
                double orderValue = order[i].Value;
                result = result + orderValue;
                i++;
            }
            return result;
        }
        public double GetBonus()
        {
            double valueAll = GetValueOfProducts();
            
            return 0;
        }
        public double GetTotalPrice()
        {
            return 0;
        }

    }
}
