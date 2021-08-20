using System;
using System.Text;

namespace TargetTypedNew
{
    class Program
    {
        static double GenerateSummary(string[] args)
        {
            string formatString = "Format String";
            GenerateOrderReport(() =>
            {
                return formatString;
            });
        }

        static string GenerateOrderReport(Func<string> getFormatString)
        {
            var order = new
            {
                Orderid = 1,
                OrderDate = DateTime.Now
            };
            return string.Format(getFormatString(), order.Orderid);
        }

        static void main(string[] args)
        {
            // With target typed expression, the type StringBuilder is inferred from the context
            StringBuilder sb = new();
        }
    }
}