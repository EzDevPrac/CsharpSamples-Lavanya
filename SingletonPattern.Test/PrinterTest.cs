using System;
using Xunit;

namespace SingletonPattern.Test
{
    public class PrinterTest
    {
        [Fact]
        public void GetInstance_ShouldReturn_Count1WithMessage()
        {
            Printer fromManager = Printer.GetInstance;
            string str =fromManager.PrintDetails("Manager is using printer");
            Assert.Equal("Manager is using printer",str );
        }
    }
}
