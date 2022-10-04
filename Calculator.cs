using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate("2+2*2/2"));
            Console.ReadLine();
        }

        public static double Calculate(string expression)
        {
            var loDataTable = new System.Data.DataTable();
            var loDataColumn = new System.Data.DataColumn("Eval", typeof(double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return (double)(loDataTable.Rows[0]["Eval"]);
        }
    }
}
