using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Data;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Console
{
    public static class Seed
    {
        public static void AddServicios(IRepository<Servicio> servicioRepo)
        {
            servicioRepo.Insert(new List<Servicio>
            {
                new Servicio {Id = 1, NombreServicio = "Tratamiento Cucarachas", Precio = 100},
                new Servicio {Id = 2, NombreServicio = "Tratamiento Hormigas", Precio = 100},
                new Servicio {Id = 3, NombreServicio = "Tratamiento Chinches", Precio = 100},
                new Servicio {Id = 4, NombreServicio = "Tratamiento Termita", Precio = 100},
                new Servicio {Id = 5, NombreServicio = "Tratamiento Carcoma", Precio = 100},
                new Servicio {Id = 6, NombreServicio = "Tratamiento Avispas", Precio = 100},
                new Servicio {Id = 7, NombreServicio = "Tratamiento Moscas", Precio = 100},
                new Servicio {Id = 8, NombreServicio = "Tratamiento Mosquitos", Precio = 100}
            });
        }

        public static void AddClients(IRepository<Cliente> clientRepo)
        {
            clientRepo.Insert(new List<Cliente>
            {
                new Cliente
                {
                    NombreCompleto = "Florin Ciobanu", CorreoElectronico = "cflorin@hiberus.com",
                    Telefono = "643447860", Direccion = "Zaragoza, Spain", CodicoPostal = "50009"
                },
                new Cliente
                {
                    NombreCompleto = "Duis Dorado", CorreoElectronico = "dluis@hiberus.com",
                    Telefono = "643447860", Direccion = "Zaragoza, Spain", CodicoPostal = "50010"
                },
                new Cliente
                {
                    NombreCompleto = "Ana Marin", CorreoElectronico = "mana@hiberus.com",
                    Telefono = "643447860", Direccion = "Zaragoza, Spain", CodicoPostal = "50010"
                }
            });
        }
    }
}
