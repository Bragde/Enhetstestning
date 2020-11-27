using Enhetstestning.math;
using NUnit.Framework;

namespace Enhetstestning.UnitTests
{
    public class MyMathTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_OneAndTwo_ReturnsThree()
        {
            var result = MyMath.Add("1", "2");

            Assert.That(result == 3);
        }

        //[Test]
        //public void Sub_TwoFromThree_ReturnsOne()
        //{
        //    var result = MyMath.Sub(3, 2);

        //    Assert.That(result == 1);
        //}

        //[Test]
        //public void Mul_TwoWithThree_ReturnsSix()
        //{
        //    var result = MyMath.Mul(2, 3);

        //    Assert.That(result == 6);
        //}

        //[Test]
        //public void Div_NineWithThree_ReturnsThree()
        //{
        //    var result = MyMath.Div(9, 3);

        //    Assert.That(result == 3);
        //}

        //[Test]
        //public void Pow_FourToThree_ReturnsSixtyFour()
        //{
        //    var result = MyMath.Pow(4, 3);

        //    Assert.That(result == 64);
        //}
    }
}