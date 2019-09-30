using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDefensa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Tests
{
    [TestClass]
    public class UnidadShould
    {
        [TestMethod]
        public void HaveName()
        {
            var unidad1 = FakeUnidades.GetAmetrallador();

            Assert.IsNotNull(unidad1.Nombre);
        }

        [TestMethod]
        public void HavePrice()
        {
            var unidad1 = FakeUnidades.GetCanon();

            Assert.IsNotNull(unidad1.Precio);
        }

        [TestMethod]
        public void HaveMovilidad()
        {
            var unidad1 = FakeUnidades.GetInfanteriaBasica();

            Assert.IsTrue(unidad1.GetMovilidad() > 1);
        }

        [TestMethod]
        public void NotHaveMovilidadIfInjured()
        {
            var unidad1 = FakeUnidades.GetInfanteriaBasica();

            unidad1.SetMovilidad(new Injured());

            Assert.AreEqual(0, unidad1.GetMovilidad());
        }

        [TestMethod]
        public void HaveImprovedMobilityAfterEquiped()
        {
            var unidad1 = FakeUnidades.GetInfanteriaBasica();

            Assert.IsTrue(unidad1.GetMovilidad() > 1);

            unidad1.SetMovilidad(new Bicycle());

            Assert.IsTrue(unidad1.GetMovilidad() > 1);
            Assert.AreEqual(10, unidad1.GetMovilidad());
        }

        [TestMethod]
        public void HaveAttackPowerAfterEquiped()
        {
            var sanitaro = FakeUnidades.GetSanitario();

            Assert.AreEqual(0, sanitaro.GetPotenciaFuego());

            sanitaro.SetDestructor(new Bazooka());

            Assert.AreEqual(10000, sanitaro.GetPotenciaFuego());
        }

        [TestMethod]
        public void NotHaveArmorByDefault()
        {
            var basic = FakeUnidades.GetInfanteriaBasica();

            Assert.AreEqual(0, basic.GetBlindaje());
        }

        [TestMethod]
        public void HaveArmorAfterEquiped()
        {
            var basic = FakeUnidades.GetInfanteriaBasica();

            Assert.AreEqual(0, basic.GetBlindaje());

            basic.SetBlindaje(new Shield());

            Assert.AreEqual(100, basic.GetBlindaje());
        }
    }
}
