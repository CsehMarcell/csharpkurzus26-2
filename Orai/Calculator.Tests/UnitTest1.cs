using Calculator.Core;

namespace Calculator.Tests;

public class ICalulatorTests
{
    private ICalculator _sut;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _sut = CalculatorFactory.Create();
    }

    [TestCase("")]
    [TestCase(" ")]
    [TestCase("asdf")]
    public void EnsureThat_Calculator_Calculate_ReturnsError_For_Invalid_Input(string input)
    {
        // Act
        var result = _sut.Calculate(input);
        bool isException = result.TryGetError(out _);

        // Assert
        Assert.That(isException, Is.True);
    }

    [TestCase("2 1 +", 3)]
    [TestCase("2 2 +", 4)]
    [TestCase("1 3 /", 0.3333333)]
    public void EnsureThat_Calculator_Calculate_ReturnsExpected_GoodResult(string input, double expectedResult)
    {
        // Act
        var result = _sut.Calculate(input);
        bool isSuccess = result.TryGetSuccess(out double calculated);

        // Assert
        Assert.That(isSuccess, Is.True);
        Assert.That(calculated, Is.EqualTo(expectedResult).Within(0.001));
    }
}
