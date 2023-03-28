using FinalProject_SimpleDilutionCalculator;
using Xunit;

namespace FinalProject_SimpleDilutionCalculator.test
{
    public class DilutionCalculatorTest
    {
        [Theory]
        [InlineData(new object[] { 1, 100, 0.8, "g/L", "L", "mg/mL" })]
        public void CalculatesDiluentVolume(double initialConcentration, double initialVolume, double finalConcentration, string initialConcentrationUnit, string initialVolumeUnit, string finalConcentrationUnit)
        {


            {

                double expectedOutput = Math.Abs(((initialConcentration * initialVolume) / finalConcentration) - initialVolume);

                DilutionCalculator calculator = new DilutionCalculator(initialConcentration, initialConcentrationUnit, initialVolume, initialVolumeUnit, finalConcentration, finalConcentrationUnit);
                {


                    Assert.Equal(expectedOutput, calculator.DiluentVolume());

                }
            }
        }
    }
}

