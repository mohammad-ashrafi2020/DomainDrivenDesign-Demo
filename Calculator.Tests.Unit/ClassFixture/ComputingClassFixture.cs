using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.Unit.ClassFixture
{
    public class ComputingClassFixture : IDisposable
    {
        public Computing computing;
        public ComputingClassFixture()
        {
            computing = new();
        }

        public void Dispose()
        {
            //
        }
    }
}
