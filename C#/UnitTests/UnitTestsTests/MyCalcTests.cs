using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    [TestClass()]
    public class MyCalcTests
    {
        [TestMethod()]
        public void SumTest()
        {
            //Настройка
            int x = 10;
            int y = 20;
            int expected = 30;

            //Используем метод
            MyCalc myCalc = new MyCalc();
            var actual = myCalc.Sum(x, y);

            //Тест
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultyTest()
        {
            //Настройка
            int x = 10;
            int y = 20;
            int expected = 200;

            //Используем метод
            MyCalc myCalc = new MyCalc();
            var actual = myCalc.Multy(x, y);

            //Тест
            Assert.AreEqual(expected, actual);
        }
    }
    
}