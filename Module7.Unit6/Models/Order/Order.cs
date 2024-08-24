using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit6.Models.Order
{
    internal class Order<TDelivery> where TDelivery : Delivery
    {
        public int Number;
        public string DEscription;


    }
}
