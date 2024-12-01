using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class NotAvailableException : Exception
    {

        public NotAvailableException() { 
        
        
        }  
        public NotAvailableException(string? message) : base(message)
        {
        }
    }
}
