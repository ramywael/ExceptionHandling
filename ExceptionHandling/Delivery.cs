using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Delivery
    {
        public string Id { get; set; }
        public string CustomerName { get; set; }

        public string Adress { get; set; }

        public EnDeliveryStatus DeliveryStatus { get; set; }
        public override string ToString()
        {
            return $"{{\n{Id},\n{CustomerName},\n{Adress},\n{DeliveryStatus}\n}}";
        }
    }


  
}
