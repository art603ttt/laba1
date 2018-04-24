using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication.Models;

namespace WebApplication.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscounteHelper getTestObject()
        {
            return new MinimumDiscountHelper();
        }
        [TestMethod]
        public void DiscountAbove100()
        {
            //arrange
            var target = getTestObject();
            const decimal total = 200m;
            //act
            var discountedTotal = target.ApplyDiscount(total);
            //assert
            Assert.AreEqual(total * 0.9m, discountedTotal);
        }

        [TestMethod]
        public void DiscountBetween10And100()
        {
            //arrange
            var target = getTestObject();
            //act
            var tenDollarDiscount = target.ApplyDiscount(10);
            var hudredDollarDiscount = target.ApplyDiscount(100);
            var fiftyDollarDiscount = target.ApplyDiscount(50);
            //assert
            Assert.AreEqual(5, tenDollarDiscount, "10$ discount is wrong");
            Assert.AreEqual(95, hudredDollarDiscount, "100$ discount is wrong");
            Assert.AreEqual(45, fiftyDollarDiscount, "50$ discount is wrong");
        }
        [TestMethod]
        public void DiscountLess10()
        {
            //arrange
            var target = getTestObject();
            //act
            var discount5 = target.ApplyDiscount(5);
            var discount0 = target.ApplyDiscount(0);

            //assert
            Assert.AreEqual(5, discount5);
            Assert.AreEqual(0, discount0);
        }
        [TestMethod]
        [ExpectedException((typeof(ArgumentOutOfRangeException)))]
        public void DiscountNegativeTotal()
        {
            //arrange
            var target = getTestObject();
            //act
            target.ApplyDiscount(-1);
        }
    }
}
