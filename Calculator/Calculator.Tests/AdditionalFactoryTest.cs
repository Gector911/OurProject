﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.One_Argument;

namespace Calculator.Tests
{
    class AdditionalFactoryTest
    {
        [TestCase("sin", typeof(sin))]
        [TestCase("cos", typeof(cos))]
        [TestCase("tg", typeof(tg))]
        [TestCase("ctg", typeof(ctg))]
        [TestCase("lg", typeof(lg))]
        [TestCase("ln", typeof(ln))]
        [TestCase("arcsin", typeof(arcsin))]
        [TestCase("arccos", typeof(arccos))]
        [TestCase("arctg", typeof(arctg))]
        [TestCase("sinh", typeof(sinh))]
        [TestCase("cosh", typeof(cosh))]
        [TestCase("tgh", typeof(tgh))]
        [TestCase("decad", typeof(decad))]
        [TestCase("sqrt", typeof(sqrt))]
        [TestCase("exponent", typeof(exponent))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = AdditionalFactory.CreateAdditionalCalculator(name);
            Assert.IsInstanceOf(type, calculator);

        }

        public void Exception()

        {
            Assert.Throws<Exception>(() => AdditionalFactory.CreateAdditionalCalculator("Wrong operation"));
        }


    }
}
