using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14HW
{
    public class Decoration
    {
        public Decoration(string line)
        { 
        
            var split = line.Split(',');    
            DecorationID = Convert.ToInt32(split[0]);
            DecorationName = split[1];
        
        
        }
        public int DecorationID { get; set; }
        public string DecorationName { get; set;}
    


    }
}
