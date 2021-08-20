using System.Text;

namespace TargetTypedNew
{
    class Program
    {
        static void main(string[] args)
        {
            // With target typed expression, the type StringBuilder is inferred from the context
            StringBuilder sb = new();
        }
    }
}