using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class RecordNotFundException:Exception
    {
        public RecordNotFundException(string message):base(message) 
        
        {
            
        }
    }
}
