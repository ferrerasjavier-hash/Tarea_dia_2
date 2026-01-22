using Xunit;

/// <summary>
/// Tests para los ejercicios de la Tarea Día 2
/// </summary>
public class ProgramTests
{
    #region Tests - El Portero de Discoteca

    [Fact]
    public void DoormanOfNightclub_AgeUnder18_ShouldReturnDenied()
    {
        // Arrange
        int age = 15;

        // Act
        string result = DoormanOfNightclub.CheckAccess(age);

        // Assert
        Assert.Equal("Fuera de aquí", result);
    }

    [Fact]
    public void DoormanOfNightclub_AgeEqualTo18_ShouldReturnWelcome()
    {
        // Arrange
        int age = 18;

        // Act
        string result = DoormanOfNightclub.CheckAccess(age);

        // Assert
        Assert.Equal("Bienvenido a la fiesta", result);
    }

    [Fact]
    public void DoormanOfNightclub_AgeInRange_ShouldReturnWelcome()
    {
        // Arrange
        int age = 30;

        // Act
        string result = DoormanOfNightclub.CheckAccess(age);

        // Assert
        Assert.Equal("Bienvenido a la fiesta", result);
    }

    [Fact]
    public void DoormanOfNightclub_AgeEqualTo60_ShouldReturnWelcome()
    {
        // Arrange
        int age = 60;

        // Act
        string result = DoormanOfNightclub.CheckAccess(age);

        // Assert
        Assert.Equal("Bienvenido a la fiesta", result);
    }

    [Fact]
    public void DoormanOfNightclub_AgeOver60_ShouldReturnBingo()
    {
        // Arrange
        int age = 65;

        // Act
        string result = DoormanOfNightclub.CheckAccess(age);

        // Assert
        Assert.Equal("Señor, el bingo es al lado", result);
    }

    #endregion

    #region Tests - Calculadora Humilde (Switch)

    [Fact]
    public void HumbleCalculator_Addition_ShouldReturnCorrectResult()
    {
        // Arrange
        double num1 = 5;
        double num2 = 3;
        int operation = 1; // Sumar

        // Act
        double result = HumbleCalculator.Calculate(num1, num2, operation);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void HumbleCalculator_Subtraction_ShouldReturnCorrectResult()
    {
        // Arrange
        double num1 = 10;
        double num2 = 4;
        int operation = 2; // Restar

        // Act
        double result = HumbleCalculator.Calculate(num1, num2, operation);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void HumbleCalculator_Multiplication_ShouldReturnCorrectResult()
    {
        // Arrange
        double num1 = 6;
        double num2 = 7;
        int operation = 3; // Multiplicar

        // Act
        double result = HumbleCalculator.Calculate(num1, num2, operation);

        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void HumbleCalculator_WithNegativeNumbers_ShouldWork()
    {
        // Arrange
        double num1 = -5;
        double num2 = 3;
        int operation = 1; // Sumar

        // Act
        double result = HumbleCalculator.Calculate(num1, num2, operation);

        // Assert
        Assert.Equal(-2, result);
    }

    #endregion

    #region Tests - Detector de Pares

    [Fact]
    public void EvenOddDetector_EvenNumber_ShouldReturnPAR()
    {
        // Arrange
        int number = 4;

        // Act
        string result = EvenOddDetector.DetectEvenOdd(number);

        // Assert
        Assert.Equal("PAR", result);
    }

    [Fact]
    public void EvenOddDetector_OddNumber_ShouldReturnIMPAR()
    {
        // Arrange
        int number = 7;

        // Act
        string result = EvenOddDetector.DetectEvenOdd(number);

        // Assert
        Assert.Equal("IMPAR", result);
    }

    [Fact]
    public void EvenOddDetector_ZeroShouldReturnPAR()
    {
        // Arrange
        int number = 0;

        // Act
        string result = EvenOddDetector.DetectEvenOdd(number);

        // Assert
        Assert.Equal("PAR", result);
    }

    [Fact]
    public void EvenOddDetector_NegativeEvenNumber_ShouldReturnPAR()
    {
        // Arrange
        int number = -6;

        // Act
        string result = EvenOddDetector.DetectEvenOdd(number);

        // Assert
        Assert.Equal("PAR", result);
    }

    [Fact]
    public void EvenOddDetector_NegativeOddNumber_ShouldReturnIMPAR()
    {
        // Arrange
        int number = -3;

        // Act
        string result = EvenOddDetector.DetectEvenOdd(number);

        // Assert
        Assert.Equal("IMPAR", result);
    }

    #endregion
}
