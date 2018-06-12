using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    
    namespace tdd
{
    [TestFixture]
    class test
    {
        /// <summary>
        /// Тест побуждающий создать класс модели
        /// </summary>
        [Test]
        public void BarkleyGameCreationTest()
        {
            BarkleyModel bm = new BarkleyModel();
            Assert.NotNull(bm);
        }
    }
}
