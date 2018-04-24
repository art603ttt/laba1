using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication.Models;
using Moq;

namespace WebApplication.Tests
{
    [TestClass]
    public class UnitTest2
    {
        private readonly Product[] _products =
        {
            new Product() {Name = "Kayak", Category = "Watersports", Price = 275m},
            new Product() {Name = "Lifejacket", Category = "Watersports", Price = 49.95m},
            new Product() {Name = "Soccer ball", Category = "Soccer", Price = 19.50m},
            new Product() {Name = "Corner flag", Category = "Soccer", Price = 34.95m}
        };
        [TestMethod]
        public void Sum_Products_Correctly()
        {
            //arrange
            var mock = new Mock<IDiscounteHelper>();
            mock.Setup(m => m.ApplyDiscount(It.IsAny<decimal>())).Returns<decimal>(total => total);
            var target = new LinqValueCalculator(mock.Object);
            //act
            var result = target.ValueProducts(_products);
            //assert
            Assert.AreEqual(_products.Sum(e => e.Price), result);
        }
    }
}
