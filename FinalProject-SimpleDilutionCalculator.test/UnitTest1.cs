using FinalProject_SimpleDilutionCalculator;

namespace FinalProject_SimpleDilutionCalculator.test;


public class DilutionCalculatorTests
{
    [Theory]
    [InlineData(new object[] {1, 100, 0.8})]
    public void CalculatesDiluentVolume(double initialConcentration, double initialVolume, double finalConcentration)

    {

        double expectedOutput = Math.Abs(
            ((initialConcentration * initialVolume) / finalConcentration) - initialVolume);

        DilutionCalculator calculator = new DilutionCalculator(initialConcentration, initialVolume, finalConcentration);

        Assert.Equal(expectedOutput, calculator.DiluentVolume);

    }

    
}
