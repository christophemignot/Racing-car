using System;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    /// <summary>
    /// Extract ISensor interface to mock easily
    /// </summary>
    public class Sensor : ISensor
    {
        private const double Offset = 16;

        public double PopNextPressurePsiValue()
        {
            return Offset + SamplePressure();
        }

        //Made static too avoid memory leak
        private static readonly Random BasicRandomNumbersGenerator = new Random();

        /// <summary>
        /// Placeholder implementation that simulate a real sensor in a real tire
        /// </summary>
        /// <returns></returns>
        private static double SamplePressure()
        {
            
            return 6 * BasicRandomNumbersGenerator.NextDouble() * BasicRandomNumbersGenerator.NextDouble();
        }
    }
}
