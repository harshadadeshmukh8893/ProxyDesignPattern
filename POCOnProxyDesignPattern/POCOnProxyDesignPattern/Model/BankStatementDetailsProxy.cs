using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnProxyDesignPattern.Model
{
    // Proxy controls access to the real source
    internal class BankStatementDetailsProxy : IBankStatementDetails
    {
        private RealBankStatementDetails _statementDetails;
        private string _username;
        private string _password;

        public BankStatementDetailsProxy(string username,string password)
        {
            _username = username;
            _password = password;
        }
        public void AccessDetails()
        {
            if (AuthenticateUser())
            {
                if (_statementDetails == null)
                {
                    _statementDetails = new RealBankStatementDetails();
                }
                _statementDetails.AccessDetails();
            }
            else
            {
                Console.WriteLine("Access denied. Invalid credentials.");
            }

        }
        private bool AuthenticateUser()
        {
            // Simulate authentication logic
            return _username == "admin" && _password == "admin@123";
        }

    }
}

