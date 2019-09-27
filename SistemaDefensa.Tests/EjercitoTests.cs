using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDefensa.Domain;

namespace SistemaDefensa.Tests
{
    [TestClass]
    public class EjercitoTests
    {
        private Unidad _unidad1;
        private Unidad _unidad2;
        private Unidad _unidad3;
        private Unidad _unidad4;
        private Unidad _unidad5;
        private Unidad _unidad6;
        private Unidad _unidad7;
        private Unidad _unidad8;
        private Unidad _unidad9;

        [TestInitialize]
        public void Initialize()
        {
            AbstractUnidadFactory caballeriaFactory = AbstractUnidadFactory.GetFactory(Division.Caballeria);
            AbstractUnidadFactory infanteriaFactory = AbstractUnidadFactory.GetFactory(Division.Infanteria);
            AbstractUnidadFactory artilleriaFactory = AbstractUnidadFactory.GetFactory(Division.Artilleria);

            _unidad1 = caballeriaFactory.GetUnidad(SubDivision.Caballeria_TransporteMX7899);
            _unidad2 = caballeriaFactory.GetUnidad(SubDivision.Caballeria_TanqueAtaqueSombrasVB98);
            _unidad3 = caballeriaFactory.GetUnidad(SubDivision.Caballeria_TransporteTAXIN66);
            _unidad4 = infanteriaFactory.GetUnidad(SubDivision.Infanteria_InfanteriaBasica);
            _unidad5 = infanteriaFactory.GetUnidad(SubDivision.Infanteria_Ametrallador);
            _unidad6 = infanteriaFactory.GetUnidad(SubDivision.Infanteria_Sanitario);
            _unidad7 = artilleriaFactory.GetUnidad(SubDivision.Artilleria_CanonAntiaereo);
            _unidad8 = artilleriaFactory.GetUnidad(SubDivision.Artilleria_TorpederoMovil);
            _unidad9 = artilleriaFactory.GetUnidad(SubDivision.Artilleria_Canon);
        }

        [TestMethod]
        public void Capacidad_militar_test_1()
        {
            // Arange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad1);
            ejercito.AddUnidad(_unidad2);
            ejercito.AddUnidad(_unidad3);
            ejercito.AddUnidad(_unidad4);
            ejercito.AddUnidad(_unidad5);
            ejercito.AddUnidad(_unidad6);
            ejercito.AddUnidad(_unidad7);
            ejercito.AddUnidad(_unidad8);
            ejercito.AddUnidad(_unidad9);

            // Act
            double actual = ejercito.CapacidadMilitar();
            double expected = 0.44145;

            // Asert
            Assert.AreEqual(expected, actual, 0.00001);
        }

        [TestMethod]
        public void Counter_unidades_test1()
        {
            // Arange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad1);
            ejercito.AddUnidad(_unidad2);
            ejercito.AddUnidad(_unidad3);
            ejercito.AddUnidad(_unidad4);
            ejercito.AddUnidad(_unidad5);
            ejercito.AddUnidad(_unidad6);
            ejercito.AddUnidad(_unidad7);
            ejercito.AddUnidad(_unidad8);
            ejercito.AddUnidad(_unidad9);

            // Act
            int actual = ejercito.CounterUnidades();
            int expected = 9;

            // Asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Counter_unidades_test2()
        {
            // Arange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad1);
            ejercito.AddUnidad(_unidad2);
            ejercito.AddUnidad(_unidad3);
            ejercito.AddUnidad(_unidad4);
            ejercito.AddUnidad(_unidad5);
            ejercito.AddUnidad(_unidad6);
            ejercito.AddUnidad(_unidad7);
            ejercito.AddUnidad(_unidad8);
            ejercito.AddUnidad(_unidad9);

            // Act
            int actual = ejercito.CounterUnidades();
            int expected = 9;

            // Asert
            Assert.AreEqual(expected, actual);

            ejercito.RemoveUnidad(_unidad1);

            actual = ejercito.CounterUnidades();
            expected = 8;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CapacidadDeMovimiendo_UnidadSinCapacidadDeMovimiento_DebeDevolverUno()
        {
            // Arrange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad9);

            // Act
            double actual = ejercito.Movimiento();
            double expected = 1.0;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CapacidadDeMovimiendo_UnidadesConVariasCapacidadesDeMovimiento_DebeDevolverElMinimo()
        {
            // Arrange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad1);
            ejercito.AddUnidad(_unidad7);

            // Act
            double actual = ejercito.Movimiento();
            double expected = 1.0;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PotenciaDeFuego_UnidadesSinPotenciaDeFuego_DebeDevolverUno()
        {
            // Arrange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad3);
            ejercito.AddUnidad(_unidad6);

            // Act
            double actual = ejercito.PotenciaDeFuego();
            double expected = 1.0;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PotenciaDeFuego_UnidadesConPotenciaDeFuego_DebeDevolverElTotal()
        {
            // Arrange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad2);
            ejercito.AddUnidad(_unidad4);

            // Act
            double actual = ejercito.PotenciaDeFuego();
            double expected = 16.8;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ResistenciaAlAtaque_UnidadesSinResistenciaAlAtaque_DebeDevolverZero()
        {
            // Arrange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad4);
            ejercito.AddUnidad(_unidad5);

            // Act
            double actual = ejercito.Blindaje();
            double expected = 0.0;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ResistenciaAlAtaque_ConResistenciaAlAtaque_DebeDevolverPromedio()
        {
            // Arrange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad1);
            ejercito.AddUnidad(_unidad2);

            // Act
            double actual = ejercito.Blindaje();
            double expected = 3.1;

            // Assert
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void CapacidadMilitar_Test1()
        {
            // Arrange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad1);
            ejercito.AddUnidad(_unidad2);
            ejercito.AddUnidad(_unidad3);
            ejercito.AddUnidad(_unidad4);
            ejercito.AddUnidad(_unidad5);
            ejercito.AddUnidad(_unidad6);
            ejercito.AddUnidad(_unidad7);
            ejercito.AddUnidad(_unidad8);
            ejercito.AddUnidad(_unidad9);

            // Act
            double actual = ejercito.CapacidadMilitar();
            double expected = 0.41508;

            // Assert
            Assert.AreEqual(expected, actual, 0.00001);
        }

        [TestMethod]
        public void CapacidadMilitar_CuandoElBlindajeEs100_DebeLansarUnaExeption()
        {
            // Arrange
            Ejercito ejercito = new Ejercito();

            ejercito.AddUnidad(_unidad1);

            // Act
            _unidad1.SetBlindaje(new ConBlindaje(100));

            var tmp = ejercito.CapacidadMilitar();

            // Assert
            Assert.ThrowsException<DivideByZeroException>(() => ejercito.CapacidadMilitar());
        }
    }
}
