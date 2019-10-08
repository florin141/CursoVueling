using ControlPlagas.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ControlPlagas.Services.IntegrationTests
{
    public class ClienteServiceTests : IntegrationTestsBase
    {
        [Fact]
        public void Can_add_new_client_to_db()
        {
            var cliente = new Cliente
            {
                NombreCompleto = "Florin Ciobanu",
                CorreoElectronico = "cflorin@hiberus.com",
                Telefono = "643447860",
                Direccion = "Zaragoza, Spain",
                CodicoPostal = "50009"
            };

            ClienteService.Insert(cliente);

            var fromDb = ClienteService.GetById(1);

            Assert.NotNull(fromDb);
        }
    }
}
