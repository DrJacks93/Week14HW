using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14HW
{
    public class Orders
    {
        public Orders(string n, string d, string des) 
        {
            OrderName = n;
            OrderDecortation = d;
            OrderDesign = des;
   
        }

        public string OrderName { get; set; }
        public string OrderDecortation { get;
        set; }  
        public string OrderDesign { get; set; }
        




    }
}
