using System;
using NUnit.Framework;
using TriangleSolver;


namespace TriangleLib.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Analyzetriangle_Zeroside_ReturnsZeroErorrMessage()
        {
            int firstSide = 0, secondSide= 5, thirdSide = 5;

            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

       

        [Test]
        public void AnalyzeTriangle_EqualEachSide_ReturnsEquilateralMessage()
        {
            int firstSide = 4, secondSide = 4, thirdSide = 4;

            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("Equilateral triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_EqualTwoSide_ReturnsIsosclelesMessage()
        {
            int firstSide = 3, secondSide = 3, thirdSide = 5;

            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_EqualTwoSidePermutations_ReturnsIsosclelesMessage()
        {
            int firstSide = 3, secondSide = 5, thirdSide = 3;

            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_DifferentSide_ReturnScaleneMessage()
        {

            int firstSide = 3, secondSide = 4, thirdSide = 5;

            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_SumOfAdjacentSidesEqualsThirdSide_ReturnInvalidMessage()
        {

            int firstSide = 3, secondSide = 4, thirdSide = 7;

            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("INVALID!!", result);
        }

        [Test]
        public void AnalyzeTriangle_SumOfAdjacentSidesEqualsThirdSidePermutation_ReturnInvalidMessage()
        {

            int firstSide = 7, secondSide = 4, thirdSide = 3;

            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("INVALID!!", result);
        }

        [Test]
        public void Analyzetriangle_Negativeside_ReturnsinvalidMessage()
        {
            int firstSide = -1, secondSide = 6, thirdSide = 5;

            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("INVALID!!", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroOnSecondSide_ReturnsZeroErrorMessage()
        {
            // zero on the middle parameter
            string result = Triangle.AnalyzeTriangle(5, 0, 5);
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroOnThirdSide_ReturnsZeroErrorMessage()
        {
            // zero on the last parameter
            string result = Triangle.AnalyzeTriangle(5, 5, 0);
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [Test]
        public void AnalyzeTriangle_NegativeSecondSide_ReturnsInvalidMessage()
        {
            // negative middle → falls through to inequality check
            string result = Triangle.AnalyzeTriangle(5, -1, 5);
            Assert.AreEqual("INVALID!!", result);
        }

        [Test]
        public void AnalyzeTriangle_NegativeThirdSide_ReturnsInvalidMessage()
        {
            // negative last → falls through to inequality check
            string result = Triangle.AnalyzeTriangle(5, 5, -1);
            Assert.AreEqual("INVALID!!", result);
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesThirdPermutation_ReturnsIsoscelesMessage()
        {
            // the third permutation of two‐equal sides
            string result = Triangle.AnalyzeTriangle(5, 3, 3);
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneSecondPermutation_ReturnsScaleneMessage()
        {
            // a different scalene ordering
            string result = Triangle.AnalyzeTriangle(4, 6, 5);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_MinimumEquilateral_ReturnsEquilateralMessage()
        {
            // smallest non‐zero equal sides
            string result = Triangle.AnalyzeTriangle(1, 1, 1);
            Assert.AreEqual("Equilateral triangle", result);
        }
    }
}
