namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AlarmTest
    {
        [TestMethod]
        public void Foo()
        {
            Alarm alarm = new Alarm();
            Assert.AreEqual(false, alarm.AlarmOn);
        }
    }
}