using NUnit.Framework;
namespace Test

{
    public class Tests
    {
        [Test]
        public void TestFlareNozzleDiameterValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.NozzleDiameter = 0.02;
            var validationMessages = validator.Validate(nameof(state.NozzleDiameter));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.NozzleDiameter = 0.6;
            validationMessages = validator.Validate(nameof(state.NozzleDiameter));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.NozzleDiameter = 0.5;
            validationMessages = validator.Validate(nameof(state.NozzleDiameter));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.NozzleDiameter = 0.001;
            validationMessages = validator.Validate(nameof(state.NozzleDiameter));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.NozzleDiameter = 0.0008;
            validationMessages = validator.Validate(nameof(state.NozzleDiameter));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.NozzleDiameter = double.NaN;
            validationMessages = validator.Validate(nameof(state.NozzleDiameter));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareNozzleHeightValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.NozzleHeight = 2.0;
            var validationMessages = validator.Validate(nameof(state.NozzleHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.NozzleHeight = 3.1;
            validationMessages = validator.Validate(nameof(state.NozzleHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.NozzleHeight = 3.0;
            validationMessages = validator.Validate(nameof(state.NozzleHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.NozzleHeight = 0.0;
            validationMessages = validator.Validate(nameof(state.NozzleHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.NozzleHeight = -0.1;
            validationMessages = validator.Validate(nameof(state.NozzleHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.NozzleHeight = double.NaN;
            validationMessages = validator.Validate(nameof(state.NozzleHeight));
            Assert.AreEqual(1, validationMessages.Count());
        }
 
        [Test]
        public void TestFlareNozzleWindAngleValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.NozzleWindAngle = 23.0;
            var validationMessages = validator.Validate(nameof(state.NozzleWindAngle));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.NozzleWindAngle = 89.0;
            validationMessages = validator.Validate(nameof(state.NozzleWindAngle));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.NozzleWindAngle = 88.0;
            validationMessages = validator.Validate(nameof(state.NozzleWindAngle));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.NozzleWindAngle = -88.0;
            validationMessages = validator.Validate(nameof(state.NozzleWindAngle));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.NozzleWindAngle = -89.0;
            validationMessages = validator.Validate(nameof(state.NozzleWindAngle));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.NozzleWindAngle = double.NaN;
            validationMessages = validator.Validate(nameof(state.NozzleWindAngle));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareStemDiameterValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.StemDiameter = 12.0;
            var validationMessages = validator.Validate(nameof(state.StemDiameter));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.StemDiameter = double.PositiveInfinity;
            validationMessages = validator.Validate(nameof(state.StemDiameter));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.StemDiameter = double.MaxValue;
            validationMessages = validator.Validate(nameof(state.StemDiameter));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.StemDiameter = 0.001;
            validationMessages = validator.Validate(nameof(state.StemDiameter));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.StemDiameter = 0.0008;
            validationMessages = validator.Validate(nameof(state.StemDiameter));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.StemDiameter = double.NaN;
            validationMessages = validator.Validate(nameof(state.StemDiameter));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareDistanceToFenceValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.DistanceToFence = 20.0;
            var validationMessages = validator.Validate(nameof(state.DistanceToFence));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.DistanceToFence = 201.0;
            validationMessages = validator.Validate(nameof(state.DistanceToFence));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.DistanceToFence = 200.0;
            validationMessages = validator.Validate(nameof(state.DistanceToFence));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.DistanceToFence = 0.001;
            validationMessages = validator.Validate(nameof(state.DistanceToFence));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.DistanceToFence = 0.0008;
            validationMessages = validator.Validate(nameof(state.DistanceToFence));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.DistanceToFence = double.NaN;
            validationMessages = validator.Validate(nameof(state.DistanceToFence));
            Assert.AreEqual(0, validationMessages.Count());
        }
        [Test]
        public void TestFlareHeadCutDiameterValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.HeadCutDiameter = 0.02;
            var validationMessages = validator.Validate(nameof(state.HeadCutDiameter));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.HeadCutDiameter = double.PositiveInfinity;
            validationMessages = validator.Validate(nameof(state.HeadCutDiameter));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.HeadCutDiameter = double.MaxValue;
            validationMessages = validator.Validate(nameof(state.HeadCutDiameter));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.HeadCutDiameter = 0.001;
            validationMessages = validator.Validate(nameof(state.HeadCutDiameter));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.HeadCutDiameter = 0.0008;
            validationMessages = validator.Validate(nameof(state.HeadCutDiameter));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.HeadCutDiameter = double.NaN;
            validationMessages = validator.Validate(nameof(state.HeadCutDiameter));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareAcceptedStemHeightValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.AcceptedStemHeight = 2.0;
            var validationMessages = validator.Validate(nameof(state.AcceptedStemHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.AcceptedStemHeight = 201.0;
            validationMessages = validator.Validate(nameof(state.AcceptedStemHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.AcceptedStemHeight = 200.0;
            validationMessages = validator.Validate(nameof(state.AcceptedStemHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.AcceptedStemHeight = 1.0;
            validationMessages = validator.Validate(nameof(state.AcceptedStemHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.AcceptedStemHeight = 0.5;
            validationMessages = validator.Validate(nameof(state.AcceptedStemHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.AcceptedStemHeight = double.NaN;
            validationMessages = validator.Validate(nameof(state.AcceptedStemHeight));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareHeatCalculationHeightValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.HeatCalculationHeight = 25.0;
            var validationMessages = validator.Validate(nameof(state.HeatCalculationHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.HeatCalculationHeight = 501.0;
            validationMessages = validator.Validate(nameof(state.HeatCalculationHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.HeatCalculationHeight = 500.0;
            validationMessages = validator.Validate(nameof(state.HeatCalculationHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.HeatCalculationHeight = 0.0;
            validationMessages = validator.Validate(nameof(state.HeatCalculationHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.HeatCalculationHeight = -0.1;
            validationMessages = validator.Validate(nameof(state.HeatCalculationHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.HeatCalculationHeight = double.NaN;
            validationMessages = validator.Validate(nameof(state.HeatCalculationHeight));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareFlameEmissivityValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);
            /
            state.SetFlameEmissivity = true;
            // валидное значение
            state.FlameEmissivity = 0.5;
            var validationMessages = validator.Validate(nameof(state.FlameEmissivity));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.FlameEmissivity = 1.1;
            validationMessages = validator.Validate(nameof(state.FlameEmissivity));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.FlameEmissivity = 1.0;
            validationMessages = validator.Validate(nameof(state.FlameEmissivity));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.FlameEmissivity = 0.0;
            validationMessages = validator.Validate(nameof(state.FlameEmissivity));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.FlameEmissivity = -0.1;
            validationMessages = validator.Validate(nameof(state.FlameEmissivity));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.FlameEmissivity = double.NaN;
            validationMessages = validator.Validate(nameof(state.FlameEmissivity));
            Assert.AreEqual(1, validationMessages.Count());
            // SetFlameEmissivity = false
            state.SetFlameEmissivity = false;
            validationMessages = validator.Validate(nameof(state.FlameEmissivity));
            Assert.AreEqual(0, validationMessages.Count());
        }
        [Test]
        public void TestFlareAtmosphericTemperatureValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.AtmosphericTemperature = 10.0;
            var validationMessages = validator.Validate(nameof(state.AtmosphericTemperature));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.AtmosphericTemperature = 71.0;
            validationMessages = validator.Validate(nameof(state.AtmosphericTemperature));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.AtmosphericTemperature = 70.0;
            validationMessages = validator.Validate(nameof(state.AtmosphericTemperature));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.AtmosphericTemperature = -70.0;
            validationMessages = validator.Validate(nameof(state.AtmosphericTemperature));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.AtmosphericTemperature = -71.0;
            validationMessages = validator.Validate(nameof(state.AtmosphericTemperature));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.AtmosphericTemperature = double.NaN;
            validationMessages = validator.Validate(nameof(state.AtmosphericTemperature));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareOutflowCoefficientValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.OutflowCoefficient = 0.2;
            var validationMessages = validator.Validate(nameof(state.OutflowCoefficient));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.OutflowCoefficient = 1.1;
            validationMessages = validator.Validate(nameof(state.OutflowCoefficient));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.OutflowCoefficient = 1.0;
            validationMessages = validator.Validate(nameof(state.OutflowCoefficient));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.OutflowCoefficient = 0.1;
            validationMessages = validator.Validate(nameof(state.OutflowCoefficient));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.OutflowCoefficient = 0.09;
            validationMessages = validator.Validate(nameof(state.OutflowCoefficient));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.OutflowCoefficient = double.NaN;
            validationMessages = validator.Validate(nameof(state.OutflowCoefficient));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareAirHumidityValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.AirHumidity = 2.0;
            var validationMessages = validator.Validate(nameof(state.AirHumidity));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.AirHumidity = 101.0;
            validationMessages = validator.Validate(nameof(state.AirHumidity));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.AirHumidity = 100.0;
            validationMessages = validator.Validate(nameof(state.AirHumidity));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.AirHumidity = 1.0;
            validationMessages = validator.Validate(nameof(state.AirHumidity));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.AirHumidity = 0.5;
            validationMessages = validator.Validate(nameof(state.AirHumidity));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.AirHumidity = double.NaN;
            validationMessages = validator.Validate(nameof(state.AirHumidity));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareAirHumExcessCoefficientValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.AirHumExcessCoefficient = 2.0;
            var validationMessages = validator.Validate(nameof(state.AirHumExcessCoefficient));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.AirHumExcessCoefficient = double.PositiveInfinity;
            validationMessages = validator.Validate(nameof(state.AirHumExcessCoefficient));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.AirHumExcessCoefficient = double.MaxValue;
            validationMessages = validator.Validate(nameof(state.AirHumExcessCoefficient));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.AirHumExcessCoefficient = 1.0;
            validationMessages = validator.Validate(nameof(state.AirHumExcessCoefficient));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.AirHumExcessCoefficient = 0.9;
            validationMessages = validator.Validate(nameof(state.AirHumExcessCoefficient));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.AirHumExcessCoefficient = double.NaN;
            validationMessages = validator.Validate(nameof(state.AirHumExcessCoefficient));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareWindSpeedValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.WindSpeed = 1.0;
            var validationMessages = validator.Validate(nameof(state.WindSpeed));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.WindSpeed = 51.0;
            validationMessages = validator.Validate(nameof(state.WindSpeed));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.WindSpeed = 50.0;
            validationMessages = validator.Validate(nameof(state.WindSpeed));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.WindSpeed = 0.01;
            validationMessages = validator.Validate(nameof(state.WindSpeed));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.WindSpeed = 0.005;
            validationMessages = validator.Validate(nameof(state.WindSpeed));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.WindSpeed = double.NaN;
            validationMessages = validator.Validate(nameof(state.WindSpeed));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareDepotLengthValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.DepotLength = 1.0;
            var validationMessages = validator.Validate(nameof(state.DepotLength));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.DepotLength = 101.0;
            validationMessages = validator.Validate(nameof(state.DepotLength));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.DepotLength = 100.0;
            validationMessages = validator.Validate(nameof(state.DepotLength));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.DepotLength = 0.0;
            validationMessages = validator.Validate(nameof(state.DepotLength));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.DepotLength = -0.1;
            validationMessages = validator.Validate(nameof(state.DepotLength));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.DepotLength = double.NaN;
            validationMessages = validator.Validate(nameof(state.DepotLength));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareVisiblePartHeightValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.VisiblePartHeight = 1.0;
            var validationMessages = validator.Validate(nameof(state.VisiblePartHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.VisiblePartHeight = 11.0;
            validationMessages = validator.Validate(nameof(state.VisiblePartHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.VisiblePartHeight = 10.0;
            validationMessages = validator.Validate(nameof(state.VisiblePartHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.VisiblePartHeight = 0.0;
            validationMessages = validator.Validate(nameof(state.VisiblePartHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.VisiblePartHeight = -1.0;
            validationMessages = validator.Validate(nameof(state.VisiblePartHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.VisiblePartHeight = double.NaN;
            validationMessages = validator.Validate(nameof(state.VisiblePartHeight));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareDepotNozzleDistanceValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.DepotNozzleDistance = 1.0;
            var validationMessages = validator.Validate(nameof(state.DepotNozzleDistance));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.DepotNozzleDistance = 101.0;
            validationMessages = validator.Validate(nameof(state.DepotNozzleDistance));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.DepotNozzleDistance = 100.0;
            validationMessages = validator.Validate(nameof(state.DepotNozzleDistance));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.DepotNozzleDistance = 0.0;
            validationMessages = validator.Validate(nameof(state.DepotNozzleDistance));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.DepotNozzleDistance = -1.0;
            validationMessages = validator.Validate(nameof(state.DepotNozzleDistance));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.DepotNozzleDistance = double.NaN;
            validationMessages = validator.Validate(nameof(state.DepotNozzleDistance));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareDepotWidthValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.DepotWidth = 1.0;
            var validationMessages = validator.Validate(nameof(state.DepotWidth));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.DepotWidth = 101.0;
            validationMessages = validator.Validate(nameof(state.DepotWidth));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.DepotWidth = 100.0;
            validationMessages = validator.Validate(nameof(state.DepotWidth));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.DepotWidth = 0.0;
            validationMessages = validator.Validate(nameof(state.DepotWidth));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.DepotWidth = -1.0;
            validationMessages = validator.Validate(nameof(state.DepotWidth));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.DepotWidth = double.NaN;
            validationMessages = validator.Validate(nameof(state.DepotWidth));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareDepotHeightValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.DepotHeight = 1.0;
            var validationMessages = validator.Validate(nameof(state.DepotHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.DepotHeight = 5.1;
            validationMessages = validator.Validate(nameof(state.DepotHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.DepotHeight = 5.0;
            validationMessages = validator.Validate(nameof(state.DepotHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.DepotHeight = 0.0;
            validationMessages = validator.Validate(nameof(state.DepotHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.DepotHeight = -0.1;
            validationMessages = validator.Validate(nameof(state.DepotHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.DepotHeight = double.NaN;
            validationMessages = validator.Validate(nameof(state.DepotHeight));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareWindVaneHeightValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.WindVaneHeight = 1.0;
            var validationMessages = validator.Validate(nameof(state.WindVaneHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.WindVaneHeight = 201.0;
            validationMessages = validator.Validate(nameof(state.WindVaneHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.WindVaneHeight = 200.0;
            validationMessages = validator.Validate(nameof(state.WindVaneHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.WindVaneHeight = 0.01;
            validationMessages = validator.Validate(nameof(state.WindVaneHeight));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.WindVaneHeight = 0.005;
            validationMessages = validator.Validate(nameof(state.WindVaneHeight));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.WindVaneHeight = double.NaN;
            validationMessages = validator.Validate(nameof(state.WindVaneHeight));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareWindSpeedAtVaneLevelValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.WindSpeedAtVaneLevel = 1.0;
            var validationMessages = validator.Validate(nameof(state.WindSpeedAtVaneLevel));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.WindSpeedAtVaneLevel = 101.0;
            validationMessages = validator.Validate(nameof(state.WindSpeedAtVaneLevel));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.WindSpeedAtVaneLevel = 100.0;
            validationMessages = validator.Validate(nameof(state.WindSpeedAtVaneLevel));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.WindSpeedAtVaneLevel = 0.01;
            validationMessages = validator.Validate(nameof(state.WindSpeedAtVaneLevel));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.WindSpeedAtVaneLevel = 0.005;
            validationMessages = validator.Validate(nameof(state.WindSpeedAtVaneLevel));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.WindSpeedAtVaneLevel = double.NaN;
            validationMessages = validator.Validate(nameof(state.WindSpeedAtVaneLevel));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareXRegionMaxValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.XRegionMax = 12.0;
            var validationMessages = validator.Validate(nameof(state.XRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.XRegionMax = 1001.0;
            validationMessages = validator.Validate(nameof(state.XRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.XRegionMax = 1000.0;
            validationMessages = validator.Validate(nameof(state.XRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.XRegionMax = -1000.0;
            validationMessages = validator.Validate(nameof(state.XRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.XRegionMax = -1001.0;
            validationMessages = validator.Validate(nameof(state.XRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.XRegionMax = double.NaN;
            validationMessages = validator.Validate(nameof(state.XRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareZRegionMinValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение, ZRegionMin <= ZRegionMax, ZRegionMin < DepotWidth / 2.0
            state.ZRegionMin = 1.0;
            state.ZRegionMax = 2.0;
            state.DepotWith = 4.0;
            var validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(0, validationMessages.Count());
            // валидное значение, ZRegionMin > ZRegionMax, ZRegionMin < DepotWidth / 2.0
            state.ZRegionMin = 1.0;
            state.ZRegionMax = 0.0;
            state.DepotWith = 4.0;
            var validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // валидное значение, ZRegionMin > ZRegionMax, ZRegionMin >= DepotWidth / 2.0
            state.ZRegionMin = 10.0;
            state.ZRegionMax = 0.0;
            state.DepotWith = 4.0;
            var validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(2, validationMessages.Count());
            // валидное значение, ZRegionMin <= ZRegionMax, ZRegionMin >= DepotWidth / 2.0
            state.ZRegionMin = 3.0;
            state.ZRegionMax = 10.0;
            state.DepotWith = 4.0;
            var validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // выше валидного диапазона
            state.ZRegionMin = 1001.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона, ZRegionMin <= ZRegionMax, ZRegionMin < DepotWidth / 2.0
            state.ZRegionMin = 1000.0;
            state.ZRegionMax = 1000.0;
            state.DepotWith = 2500.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(0, validationMessages.Count());
            // верхняя граница валидного диапазона, ZRegionMin <= ZRegionMax, ZRegionMin >= DepotWidth / 2.0
            state.ZRegionMin = 1000.0;
            state.ZRegionMax = 1000.0;
            state.DepotWith = 1000.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона, ZRegionMin > ZRegionMax, ZRegionMin < DepotWidth / 2.0
            state.ZRegionMin = 1000.0;
            state.ZRegionMax = 500.0;
            state.DepotWith = 2500.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона, ZRegionMin > ZRegionMax, ZRegionMin >= DepotWidth / 2.0
            state.ZRegionMin = 1000.0;
            state.ZRegionMax = 500.0;
            state.DepotWith = 1000.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(2, validationMessages.Count());
            // нижняя граница валидного диапазона,  ZRegionMin <= ZRegionMax, ZRegionMin < DepotWidth / 2.0
            state.ZRegionMin = -1000.0;
            state.ZRegionMax = 500.0;
            state.DepotWith = 1000.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона,  ZRegionMin <= ZRegionMax, ZRegionMin >= DepotWidth / 2.0
            state.ZRegionMin = -1000.0;
            state.ZRegionMax = 500.0;
            state.DepotWith = -2500.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // нижняя граница валидного диапазона,  ZRegionMin > ZRegionMax, ZRegionMin < DepotWidth / 2.0
            state.ZRegionMin = -1000.0;
            state.ZRegionMax = -1500.0;
            state.DepotWith = 1000.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // нижняя граница валидного диапазона,  ZRegionMin > ZRegionMax, ZRegionMin >= DepotWidth / 2.0
            state.ZRegionMin = -1000.0;
            state.ZRegionMax = -1500.0;
            state.DepotWith = -2500.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(2, validationMessages.Count());
            // ниже границы валидного диапазона
            state.ZRegionMin = -1100.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.ZRegionMin = double.NaN;
            validationMessages = validator.Validate(nameof(state.ZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareZRegionMaxValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.ZRegionMax = 2.0;
            var validationMessages = validator.Validate(nameof(state.ZRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.ZRegionMax = 1001.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.ZRegionMax = 1000.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.ZRegionMax = -1000.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.ZRegionMax = -1001.0;
            validationMessages = validator.Validate(nameof(state.ZRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.ZRegionMax = double.NaN;
            validationMessages = validator.Validate(nameof(state.ZRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlarePollutionXRegionMinValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение, PollutionXRegionMin < PollutionXRegionMax
            state.PollutionXRegionMin = 1000.0;
            state.PollutionXRegionMax = 2000.0;
            var validationMessages = validator.Validate(nameof(state.PollutionXRegionMin));
            Assert.AreEqual(0, validationMessages.Count());
            // валидное значение, PollutionXRegionMin >= PollutionXRegionMax
            state.PollutionXRegionMin = 1000.0;
            state.PollutionXRegionMax = 500.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // выше валидного диапазона
            state.PollutionXRegionMin = 51000.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона, PollutionXRegionMin < PollutionXRegionMax
            state.PollutionXRegionMin = 50000.0;
            state.PollutionXRegionMax = 51000.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMin));
            Assert.AreEqual(0, validationMessages.Count());
            // верхняя граница валидного диапазона, PollutionXRegionMin >= PollutionXRegionMax
            state.PollutionXRegionMin = 50000.0;
            state.PollutionXRegionMax = 45000.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // нижняя граница валидного диапазона,  PollutionXRegionMin < PollutionXRegionMax
            state.PollutionXRegionMin = 0.0;
            state.PollutionXRegionMax = 45000.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMin));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона,  PollutionXRegionMin >= PollutionXRegionMax
            state.PollutionXRegionMin = 0.0;
            state.PollutionXRegionMax = 0.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // ниже границы валидного диапазона
            state.PollutionXRegionMin = -1.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.PollutionXRegionMin = double.NaN;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlarePollutionXRegionMaxValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.PollutionXRegionMax = 1000.0;
            // state.PollutionXRegionMax = 0.02;
            var validationMessages = validator.Validate(nameof(state.PollutionXRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.PollutionXRegionMax = 51000.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.PollutionXRegionMax = 50000.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.PollutionXRegionMax = 0.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.PollutionXRegionMax = -1.0;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.PollutionXRegionMax = double.NaN;
            validationMessages = validator.Validate(nameof(state.PollutionXRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlarePollutionZRegionMinValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение, PollutionZRegionMin < PollutionZRegionMax 
            state.PollutionZRegionMin = 1000.0;
            state.PollutionZRegionMax = 2000.0;
            var validationMessages = validator.Validate(nameof(state.PollutionZRegionMin));
            Assert.AreEqual(0, validationMessages.Count());
            // валидное значение, PollutionZRegionMin >= PollutionZRegionMax 
            state.PollutionZRegionMin = 1000.0;
            state.PollutionZRegionMax = 750.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // выше валидного диапазона
            state.PollutionZRegionMin = 10001.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона, PollutionZRegionMin < PollutionZRegionMax
            state.PollutionZRegionMin = 10000.0;
            state.PollutionZRegionMax = 10001.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMin));
            Assert.AreEqual(0, validationMessages.Count());
            // верхняя граница валидного диапазона, PollutionZRegionMin >= PollutionZRegionMax
            state.PollutionZRegionMin = 10000.0;
            state.PollutionZRegionMax = 9000.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // нижняя граница валидного диапазона, PollutionZRegionMin < PollutionZRegionMax
            state.PollutionZRegionMin = -10000.0;
            state.PollutionZRegionMax = 9000.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMin));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона, PollutionZRegionMin >= PollutionZRegionMax
            state.PollutionZRegionMin = -10000.0;
            state.PollutionZRegionMax = -10000.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // ниже границы валидного диапазона
            state.PollutionZRegionMin = -10001.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.PollutionZRegionMin = double.NaN;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMin));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlarePollutionZRegionMaxValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.PollutionZRegionMax = 100.0;
            var validationMessages = validator.Validate(nameof(state.PollutionZRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.PollutionZRegionMax = 10001.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.PollutionZRegionMax = 10000.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.PollutionZRegionMax = -10000.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMax));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.PollutionZRegionMax = -10001.0;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.PollutionZRegionMax = double.NaN;
            validationMessages = validator.Validate(nameof(state.PollutionZRegionMax));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareEValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.E = 1.0;
            var validationMessages = validator.Validate(nameof(state.E));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.E = 101.0;
            validationMessages = validator.Validate(nameof(state.E));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.E = 100.0;
            validationMessages = validator.Validate(nameof(state.E));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.E = 0.0;
            validationMessages = validator.Validate(nameof(state.E));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.E = -1.0;
            validationMessages = validator.Validate(nameof(state.E));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.E = double.NaN;
            validationMessages = validator.Validate(nameof(state.E));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareNValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.N = 1.0;
            var validationMessages = validator.Validate(nameof(state.N));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.N = 101.0;
            validationMessages = validator.Validate(nameof(state.N));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.N = 100.0;
            validationMessages = validator.Validate(nameof(state.N));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.N = 0.0;
            validationMessages = validator.Validate(nameof(state.N));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.N = -1.0;
            validationMessages = validator.Validate(nameof(state.N));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.N = double.NaN;
            validationMessages = validator.Validate(nameof(state.N));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareSValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.S = 1.0;
            var validationMessages = validator.Validate(nameof(state.S));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.S = 101.0;
            validationMessages = validator.Validate(nameof(state.S));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.S = 100.0;
            validationMessages = validator.Validate(nameof(state.S));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.S = 0.0;
            validationMessages = validator.Validate(nameof(state.S));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.S = -1.0;
            validationMessages = validator.Validate(nameof(state.S));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.S = double.NaN;
            validationMessages = validator.Validate(nameof(state.S));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareWValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.W = 1.0;
            var validationMessages = validator.Validate(nameof(state.W));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.W = 101.0;
            validationMessages = validator.Validate(nameof(state.W));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.W = 100.0;
            validationMessages = validator.Validate(nameof(state.W));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.W = 0.0;
            validationMessages = validator.Validate(nameof(state.W));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.W = -1.0;
            validationMessages = validator.Validate(nameof(state.W));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.W = double.NaN;
            validationMessages = validator.Validate(nameof(state.W));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareNEValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.NE = 1.0;
            var validationMessages = validator.Validate(nameof(state.NE));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.NE = 101.0;
            validationMessages = validator.Validate(nameof(state.NE));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.NE = 100.0;
            validationMessages = validator.Validate(nameof(state.NE));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.NE = 0.0;
            validationMessages = validator.Validate(nameof(state.NE));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.NE = -1.0;
            validationMessages = validator.Validate(nameof(state.NE));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.NE = double.NaN;
            validationMessages = validator.Validate(nameof(state.NE));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareNWValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.NW = 1.0;
            var validationMessages = validator.Validate(nameof(state.NW));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.NW = 101.0;
            validationMessages = validator.Validate(nameof(state.NW));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.NW = 100.0;
            validationMessages = validator.Validate(nameof(state.NW));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.NW = 0.0;
            validationMessages = validator.Validate(nameof(state.NW));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.NW = -1.0;
            validationMessages = validator.Validate(nameof(state.NW));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.NW = double.NaN;
            validationMessages = validator.Validate(nameof(state.NW));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareSEValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.SE = 1.0;
            var validationMessages = validator.Validate(nameof(state.SE));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.SE = 101.0;
            validationMessages = validator.Validate(nameof(state.SE));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.SE = 100.0;
            validationMessages = validator.Validate(nameof(state.SE));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.SE = 0.0;
            validationMessages = validator.Validate(nameof(state.SE));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.SE = -1.0;
            validationMessages = validator.Validate(nameof(state.SE));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.SE = double.NaN;
            validationMessages = validator.Validate(nameof(state.SE));
            Assert.AreEqual(1, validationMessages.Count());
        }
        [Test]
        public void TestFlareSWValidator()
        {
            var state = new FlareCompositionState();
            var deviceType = DeviceType.Flare;
            var validator = this.GetValidator(state, deviceType);

            // валидное значение
            state.SW = 1.0;
            var validationMessages = validator.Validate(nameof(state.SW));
            Assert.AreEqual(0, validationMessages.Count());
            // выше валидного диапазона
            state.SW = 101.0;
            validationMessages = validator.Validate(nameof(state.SW));
            Assert.AreEqual(1, validationMessages.Count());
            // верхняя граница валидного диапазона
            state.SW = 100.0;
            validationMessages = validator.Validate(nameof(state.SW));
            Assert.AreEqual(0, validationMessages.Count());
            // нижняя граница валидного диапазона
            state.SW = 0.0;
            validationMessages = validator.Validate(nameof(state.SW));
            Assert.AreEqual(0, validationMessages.Count());
            // ниже границы валидного диапазона
            state.SW = -1.0;
            validationMessages = validator.Validate(nameof(state.SW));
            Assert.AreEqual(1, validationMessages.Count());
            // не число
            state.SW = double.NaN;
            validationMessages = validator.Validate(nameof(state.SW));
            Assert.AreEqual(1, validationMessages.Count());
        }
    }
}
