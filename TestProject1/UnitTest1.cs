using NUnit.Framework;
using Calcule;

namespace TestProject1
{
    [TestFixture]
    public class QuadraticSolverTests
    {
        [Test]
        public void Solve_TwoRealSolutions()
        {
            // Arrange
            double a = 1, b = -3, c = 2; // x² - 3x + 2 = 0

            // Act
            var result = QuadraticSolver.Solve(a, b, c);

            // Assert
            Assert.AreEqual(2, result.Item1);
            Assert.AreEqual(1, result.Item2);
        }

        [Test]
        public void Solve_OneRealSolution()
        {
            // Arrange
            double a = 1, b = -2, c = 1; // x² - 2x + 1 = 0

            // Act
            var result = QuadraticSolver.Solve(a, b, c);

            // Assert
            Assert.AreEqual(1, result.Item1);
            Assert.IsNull(result.Item2);
        }

        [Test]
        public void Solve_NoRealSolution()
        {
            // Arrange
            double a = 1, b = 2, c = 5; // x² + 2x + 5 = 0

            // Act
            var result = QuadraticSolver.Solve(a, b, c);

            // Assert
            Assert.IsNull(result.Item1);
            Assert.IsNull(result.Item2);
        }

        [Test]
        public void Solve_AEqualsZero_ThrowsException()
        {
            // Arrange
            double a = 0, b = 2, c = 3;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => QuadraticSolver.Solve(a, b, c));
        }
    }
}
