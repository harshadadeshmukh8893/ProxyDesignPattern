using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnProxyDesignPattern.Model
{
    internal class RealBankStatementDetails : IBankStatementDetails
    {
        // RealSubject represents the actual details
        public void AccessDetails()
        {
            Console.WriteLine("Accessing Bank Statement Details...");
        }
    }
}
