﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleMsTestProject.NetCore31
{
    [TestClass]
    public class TestSetUpAndTeardown
    {
        [TestInitialize]
        public void SetUp()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestCleanup]
        public void TearDown()
        {
        }
    }
}
