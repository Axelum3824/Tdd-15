using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDBarkley.TestFolder
{
    [TestFixture]
    class TestBarkley
    {
        /// <summary>
        /// Тест побуждающий создать класс модели
        /// </summary>
        [Test]
        public void BarkleyGameCreationTest()
        {
            BarkleyModel bm = = new BarkleyModel();
            Assert.NotNull(bm);
        }
    }
}
