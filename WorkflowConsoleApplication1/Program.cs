using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace WorkflowConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            var workflow1 = new Workflow1();
            workflow1.num = new InArgument<int>() { Expression = 12 };//给个输入参数num的值，由于>0，按照预期boolFlag应该为true，num为12。  

            WorkflowInvoker.Invoke(workflow1);

            Console.ReadLine();
        }
    }
}
