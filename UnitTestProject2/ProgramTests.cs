using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCF_assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace GCF_assignment.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [DataTestMethod()]
        [DataRow(10, 5)]     // Positive numbers only   // Expected(5, 5)

        public void GCDTest1(int arg1, int arg2)
        {
            int PNO = Program.GCD(arg1, arg2);
            Assert.AreEqual(PNO, 5);
        }

        [DataTestMethod()]
        [DataRow(-10, -5)]   // Negative numbers only   // Expected(-5, -5)

        public void GCDTest2(int arg1, int arg2)
        {
            int NNO = Program.GCD(arg1, arg2);
            Assert.AreEqual(NNO, -5);
        }

        [DataTestMethod()]
        [DataRow(10, -5)]   // Positive number and negative number   // Expected(-5, -5)

        public void GCDTest3(int arg1, int arg2)
        {
            int NNO = Program.GCD(arg1, arg2);
            Assert.AreEqual(NNO, -5);
        }
    }
}