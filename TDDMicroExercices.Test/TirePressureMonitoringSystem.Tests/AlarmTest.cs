namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class AlarmTest
    {
        [TestMethod]
        public void WhenAlarmCreatedThenAlarmIsOff()
        {
            Alarm alarm = new Alarm();
            Assert.AreEqual(false, alarm.AlarmOn);
        }

        [TestMethod]
        public void WhenPressure20ThenNoAlarm()
        {
            Mock<ISensor> sensor = new Mock<ISensor>(MockBehavior.Strict);
            sensor.Setup(instance => instance.PopNextPressurePsiValue()).Returns(20).Verifiable();
            Alarm alarm = new Alarm(sensor.Object);

            alarm.Check();

            Assert.AreEqual(false, alarm.AlarmOn);
            sensor.VerifyAll();
        }

        [TestMethod]
        public void WhenPressureLowThenAlarmOn()
        {
            Mock<ISensor> sensor = new Mock<ISensor>(MockBehavior.Strict);
            sensor.Setup(instance => instance.PopNextPressurePsiValue()).Returns(16.9).Verifiable();
            Alarm alarm = new Alarm(sensor.Object);

            alarm.Check();

            Assert.AreEqual(true, alarm.AlarmOn);
            sensor.VerifyAll();
        }

        [TestMethod]
        public void WhenPressureHighThenAlarmOn()
        {
            Mock<ISensor> sensor = new Mock<ISensor>(MockBehavior.Strict);
            sensor.Setup(instance => instance.PopNextPressurePsiValue()).Returns(21.1).Verifiable();
            Alarm alarm = new Alarm(sensor.Object);

            alarm.Check();

            Assert.AreEqual(true, alarm.AlarmOn);
            sensor.VerifyAll();
        }
    }
}