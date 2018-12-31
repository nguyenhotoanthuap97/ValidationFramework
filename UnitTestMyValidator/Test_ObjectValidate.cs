using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MyValidate.ValidateMethod;

namespace UnitTestMyValidator
{
    [TestClass]
    public class Test_ObjectValidate
    {
        List<object> objects = new List<object>();

        public Test_ObjectValidate()
        {
            objects.Add(null);
            objects.Add(string.Empty);
            objects.Add("");
            objects.Add(true);
            objects.Add("null");
            objects.Add(0);
        }

        [TestMethod]
        public void TestMethod1()
        {         
            Assert.IsTrue(objects[0].IsNull());
            Assert.IsTrue(objects[1].IsNotNull());
            Assert.IsFalse(objects[2].IsNull());
            Assert.IsTrue(objects[3].IsNotNull());
            Assert.IsFalse(objects[4].IsNull());
            Assert.IsFalse(objects[5].IsNull());
        }
    }
}
