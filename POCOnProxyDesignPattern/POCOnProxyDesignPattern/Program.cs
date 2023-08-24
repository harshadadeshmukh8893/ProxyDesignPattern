using POCOnProxyDesignPattern.Model;

namespace POCOnProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the proxy to access the sensitive resource
            IBankStatementDetails details = new BankStatementDetailsProxy("admin","admin@123");

            // Access the sensitive resource through the proxy
            details.AccessDetails();
        }
    }
}