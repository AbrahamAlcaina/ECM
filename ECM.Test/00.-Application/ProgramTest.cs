using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace ECM.Test.Application
{
    
    public class ProgramTest
    {
        [Fact]
        public void StartUp()
        {
            // arrange
            string[] args = { "http://localhost:80/" };

            // act
            Program.Main(args);

            // assert
        }
    }
}
