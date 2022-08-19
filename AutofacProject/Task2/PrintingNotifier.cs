using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacProject.Task2
{
    internal class PrintingNotifier : IMemoDueNotifier
    {
        TextWriter _writer; // StringWriter / System.Console.Out

        public PrintingNotifier(TextWriter writer)
        {
            _writer = writer;
        }
        public void MemoIsDue(Memo memo)
        {
            _writer.WriteLine("Memo '{0}' is due", memo.Title);
        }
    }
}
