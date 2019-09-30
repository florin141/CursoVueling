using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDefensa.Domain;
using SistemaDefensa.Domain.Exceptions;

namespace SistemaDefensa.Tests
{
    [TestClass]
    public class EjercitoShould
    {
        #region Field
        ICalculable _defaultCalc;

        Ejercito _ejercito;

        Unidad _transporteMX7899;
        Unidad _tanqueAtaqueSombrasVB98;
        Unidad _transporteTAXIN66;
        Unidad _infanteriaBasica;
        Unidad _ametrallador;
        Unidad _sanitario;
        Unidad _canonAntiaereo;
        Unidad _torpederoMovil;
        Unidad _canon;
        #endregion

        [TestInitialize]
        public void Initialize()
        {
            _defaultCalc = new DefaultCalculable();

            _ejercito = new Ejercito(_defaultCalc);

            _transporteMX7899 = FakeUnidades.GetTransporterMX7899();
            _tanqueAtaqueSombrasVB98 = FakeUnidades.GetTanqueAtaqueSombrasVB98();
            _transporteTAXIN66 = FakeUnidades.GetTransporteTAXIN66();
            _infanteriaBasica = FakeUnidades.GetInfanteriaBasica();
            _ametrallador = FakeUnidades.GetAmetrallador();
            _sanitario = FakeUnidades.GetSanitario();
            _canonAntiaereo = FakeUnidades.GetCanonAntiaereo();
            _torpederoMovil = FakeUnidades.GetTorpederoMovil();
            _canon = FakeUnidades.GetCanon();
        }

        [TestMethod]
        public void CalculateTheNumberOfUnits()
        {
            // Arrange
            _ejercito.AddUnidad(_transporteMX7899);
            _ejercito.AddUnidad(_tanqueAtaqueSombrasVB98);
            _ejercito.AddUnidad(_transporteTAXIN66);

            _ejercito.AddUnidad(_infanteriaBasica);
            _ejercito.AddUnidad(_ametrallador);
            _ejercito.AddUnidad(_sanitario);

            _ejercito.AddUnidad(_canonAntiaereo);
            _ejercito.AddUnidad(_torpederoMovil);
            _ejercito.AddUnidad(_canon);

            // Act
            int actual = _ejercito.CounterUnidades();
            int expected = 9;

            // Asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTheNumberOfUnitsAfterRemovingUnits()
        {
            // Arrange
            _ejercito.AddUnidad(_transporteMX7899);
            _ejercito.AddUnidad(_tanqueAtaqueSombrasVB98);
            _ejercito.AddUnidad(_transporteTAXIN66);

            _ejercito.AddUnidad(_infanteriaBasica);
            _ejercito.AddUnidad(_ametrallador);
            _ejercito.AddUnidad(_sanitario);

            _ejercito.AddUnidad(_canonAntiaereo);
            _ejercito.AddUnidad(_torpederoMovil);
            _ejercito.AddUnidad(_canon);

            // Act
            int actual = _ejercito.CounterUnidades();
            int expected = 9;

            // Asert
            Assert.AreEqual(expected, actual);

            _ejercito.RemoveUnidad(_transporteMX7899);

            actual = _ejercito.CounterUnidades();
            expected = 8;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void HaveInfiniteFundsWhenNoFundParamIsProvided()
        {
            // Arrange
            var ejercito = new Ejercito(_defaultCalc);
            _infanteriaBasica.Precio = double.MaxValue;

            // Act
            ejercito.AddUnidad(_infanteriaBasica);

            // Assert
            Assert.AreEqual(double.PositiveInfinity, ejercito.GetFondoDisponible());
        }

        [TestMethod]
        public void Add_SubtractTotalUnitsPriceFromExerciseFund()
        {
            // Arrange
            _ejercito.SetFondo(6000);

            _ejercito.AddUnidad(_transporteMX7899);
            _ejercito.AddUnidad(_transporteTAXIN66);

            // Act
            double actual = _ejercito.GetFondoDisponible();
            double expected = 200;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ThrowExceptionWhenExerciseHasNoFunds()
        {
            // Arrange
            _ejercito.SetFondo(6000);

            _ejercito.AddUnidad(_transporteMX7899);
            _ejercito.AddUnidad(_transporteTAXIN66);

            // Act
            // Assert
            Assert.ThrowsException<FundNotAvailableException>(() => _ejercito.AddUnidad(_infanteriaBasica));
        }

        [TestMethod]
        public void RemoveUnidad_AddsBackThePriceOfTheUnitRemoved()
        {
            // Arrange
            _ejercito.SetFondo(6000);

            _ejercito.AddUnidad(_transporteMX7899);
            _ejercito.AddUnidad(_transporteTAXIN66);

            Assert.AreEqual(200, _ejercito.GetFondoDisponible());

            // Act
            _ejercito.RemoveUnidad(_transporteMX7899);
            _ejercito.RemoveUnidad(_transporteTAXIN66);

            // Assert
            Assert.AreEqual(6000, _ejercito.GetFondoDisponible());
        }

        [TestMethod]
        public void RemoveUnidad_ThrowsExceptionWhenAttemptingToRemoveUnexistingUnit()
        {
            Assert.ThrowsException<UnidadNotFoundException>(() => _ejercito.RemoveUnidad(_sanitario));
        }


        [TestMethod]
        public void HaveZeroUnitsWhenNew()
        {
            Assert.AreEqual(0, _ejercito.CounterUnidades());
        }

        [TestMethod]
        public void CounterUnidades_HaveTwoUnitsWhenAddingTwoUnits()
        {
            _ejercito.AddUnidad(_infanteriaBasica);
            _ejercito.AddUnidad(_infanteriaBasica);

            Assert.AreEqual(2, _ejercito.CounterUnidades());
        }

        [TestMethod]
        public void PotenciaDeFuego_UnidadesSinPotenciaDeFuegoDebeDevolverZero()
        {
            // Arrange
            _ejercito.AddUnidad(_transporteTAXIN66);
            _ejercito.AddUnidad(_sanitario);

            // Act
            double actual = _ejercito.PotenciaDeFuego();
            double expected = 0.0;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PotenciaDeFuego_UnidadesConPotenciaDeFuegoDebeDevolverElTotal()
        {
            // Arrange
            _ejercito.AddUnidad(_tanqueAtaqueSombrasVB98);
            _ejercito.AddUnidad(_infanteriaBasica);

            // Act
            double actual = _ejercito.PotenciaDeFuego();
            double expected = 16.8;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CapacidadDeMovimiendo_UnidadSinCapacidadDeMovimientoDebeDevolverUno()
        {
            // Arrange
            _ejercito.AddUnidad(_canon);

            // Act
            double actual = _ejercito.Movimiento();
            double expected = 1.0;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CapacidadDeMovimiendo_UnidadesConVariasCapacidadesDeMovimientoDebeDevolverElMinimo()
        {
            // Arrange
            _ejercito.AddUnidad(_transporteMX7899);
            _ejercito.AddUnidad(_canonAntiaereo);

            // Act
            double actual = _ejercito.Movimiento();
            double expected = 1.0;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ResistenciaAlAtaque_UnidadesSinResistenciaAlAtaqueDebeDevolverZero()
        {
            // Arrange
            _ejercito.AddUnidad(_infanteriaBasica);
            _ejercito.AddUnidad(_ametrallador);

            // Act
            double actual = _ejercito.Blindaje();
            double expected = 0.0;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ResistenciaAlAtaque_ConResistenciaAlAtaqueDebeDevolverPromedio()
        {
            // Arrange
            _ejercito.AddUnidad(_transporteMX7899);
            _ejercito.AddUnidad(_tanqueAtaqueSombrasVB98);

            // Act
            double actual = _ejercito.Blindaje();
            double expected = 3.1;

            // Assert
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void CapacidadMilitar_CuandoElBlindajeEs100_DebeLansarUnaExeption()
        {
            // Arrange
            _ejercito.AddUnidad(_tanqueAtaqueSombrasVB98);

            // Act
            _tanqueAtaqueSombrasVB98.SetBlindaje(new ConBlindaje(100));

            // Assert
            Assert.ThrowsException<DivideByZeroException>(() => _ejercito.CapacidadMilitar());
        }

        [TestMethod]
        public void CapacidadMilitar_Test1()
        {
            // Arrange
            _ejercito.AddUnidad(_transporteMX7899);
            _ejercito.AddUnidad(_tanqueAtaqueSombrasVB98);
            _ejercito.AddUnidad(_transporteTAXIN66);

            _ejercito.AddUnidad(_infanteriaBasica);
            _ejercito.AddUnidad(_ametrallador);
            _ejercito.AddUnidad(_sanitario);

            _ejercito.AddUnidad(_canonAntiaereo);
            _ejercito.AddUnidad(_torpederoMovil);
            _ejercito.AddUnidad(_canon);

            // Act
            double actual = _ejercito.CapacidadMilitar();
            double expected = 0.41508;

            // Assert
            Assert.AreEqual(expected, actual, 0.00001);
        }

        
    }
}
