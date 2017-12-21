using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneWinForms.Messages
{
    public class OrderControlShowed
    {        
        public OrderControlShowed(string orderNumber)
        {
            this.OrderNumber = orderNumber;
        }

        public string OrderNumber { get; private set; }
    }
}
