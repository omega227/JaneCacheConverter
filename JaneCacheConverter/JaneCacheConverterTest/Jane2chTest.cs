using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using JaneCacheConverter;

namespace JaneCacheConverterTest
{
    [TestFixture]
    public class Jane2chTest
    {
        Jane2ch jane;
        [SetUp]
        public void Setup()
        {
            jane = new Jane2ch(@"G:\Program Files (x86)\Jane Style");
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void CategoryLoadTest()
        {
            CategoryCollection categories = jane.Categories;
            Assert.NotNull(categories);
        }
    }
}
