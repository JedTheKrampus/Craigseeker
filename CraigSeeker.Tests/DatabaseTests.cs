using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NHibernate;
using CraigSeeker;
using CraigSeeker.Models;

namespace CraigSeeker.Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void TestClassRunsATest()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void CanGetEmailAndSearchAndRSSFromDatabase()
        {

        }
        
        [Test]
        public void CanAddEmailAndSearchAndRSSToDatabase()
        {
            Repository<CraigQuery> blankRepository = new Repository<CraigQuery>();
            CraigQuery query = blankRepository.Add(new CraigQuery("sbrown655@gmail.com", "steering wheel desk"));

            Assert.AreNotSame(blankRepository.Iterator().Current, query);
            Assert.AreEqual(blankRepository.Iterator().Current.Email, "sbrown655@gmail.com");
            Assert.AreEqual(blankRepository.Iterator().Current.Search, "steering wheel desk");
        }
    }
}
