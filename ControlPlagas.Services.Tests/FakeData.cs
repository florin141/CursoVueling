using ControlPlagas.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlPlagas.Services.Tests
{
    public class FakeData
    {
        public static List<Cliente> GetClientes()
        {
            return new List<Cliente>
            {
                new Cliente
                {
                    Id = 1, NombreCompleto = "Florin Ciobanu", CorreoElectronico = "cflorin@hiberus.com",
                    Telefono = "643447860", Direccion = "Zaragoza, Spain", CodicoPostal = "50009"
                },
                new Cliente
                {
                    Id = 2, NombreCompleto = "Duis Dorado", CorreoElectronico = "dluis@hiberus.com",
                    Telefono = "643447860", Direccion = "Zaragoza, Spain", CodicoPostal = "50010"
                },
                new Cliente
                {
                    Id = 2, NombreCompleto = "Ana Marin", CorreoElectronico = "mana@hiberus.com",
                    Telefono = "643447860", Direccion = "Zaragoza, Spain", CodicoPostal = "50010"
                }
            };
        }

        public static List<Plaga> GetPlagas()
        {
            return new List<Plaga>
            {
                new Plaga { Id = 1, NombreComun = "Cucarachas", Descripcion = "Cucarachas Descripcion" },
                new Plaga { Id = 2, NombreComun = "Hormigas", Descripcion = "Hormigas Descripcion" },
                new Plaga { Id = 3, NombreComun = "Chinches", Descripcion = "Chinches Descripcion" },
                new Plaga { Id = 4, NombreComun = "Termita", Descripcion = "Termita Descripcion" },
                new Plaga { Id = 5, NombreComun = "Carcoma", Descripcion = "Carcoma Descripcion" },
                new Plaga { Id = 6, NombreComun = "Avispas", Descripcion = "Avispas Descripcion" },
                new Plaga { Id = 7, NombreComun = "Moscas", Descripcion = "Moscas Descripcion" },
                new Plaga { Id = 8, NombreComun = "Mosquitos", Descripcion = "Mosquitos Descripcion" }
            };
        }

        public static Plaga GetPlaga(string nombreComun)
        {
            return GetPlagas().SingleOrDefault(p => p.NombreComun == nombreComun);
        }

        public static List<Recurso> GetRecursos()
        {
            return new List<Recurso>
            {
                new Veneno {Id = 1, NombreRecurso = "Anti Cucarachas", Coste = 1, Plaga = GetPlaga("Cucarachas")},
                new Veneno {Id = 1, NombreRecurso = "Anti Hormigas", Coste = 1, Plaga = GetPlaga("Hormigas")},
                new Veneno {Id = 1, NombreRecurso = "Anti Chinches", Coste = 1, Plaga = GetPlaga("Chinches")},
                new Veneno {Id = 1, NombreRecurso = "Anti Termita", Coste = 1, Plaga = GetPlaga("Termita")},
                new Veneno {Id = 1, NombreRecurso = "Anti Carcoma", Coste = 1, Plaga = GetPlaga("Carcoma")},
                new Veneno {Id = 1, NombreRecurso = "Anti Avispas", Coste = 1, Plaga = GetPlaga("Avispas")},
                new Veneno {Id = 1, NombreRecurso = "Anti Moscas", Coste = 1, Plaga = GetPlaga("Moscas")},
                new Veneno {Id = 1, NombreRecurso = "Anti Mosquitos", Coste = 1, Plaga = GetPlaga("Mosquitos")},
                new Recurso {Id = 3, NombreRecurso = "Furgonetas", Coste = 10},
                new Recurso {Id = 4, NombreRecurso = "Mascarillas", Coste = 5},
                new Recurso {Id = 5, NombreRecurso = "Guantes", Coste = 1}
            };
        }

        public static List<Servicio> GetServicios()
        {
            return new List<Servicio>
            {
                new Servicio {Id = 1, NombreServicio = "Tratamiento Cucarachas", Precio = 100},
                new Servicio {Id = 2, NombreServicio = "Tratamiento Hormigas", Precio = 100},
                new Servicio {Id = 3, NombreServicio = "Tratamiento Chinches", Precio = 100},
                new Servicio {Id = 4, NombreServicio = "Tratamiento Termita", Precio = 100},
                new Servicio {Id = 5, NombreServicio = "Tratamiento Carcoma", Precio = 100},
                new Servicio {Id = 6, NombreServicio = "Tratamiento Avispas", Precio = 100},
                new Servicio {Id = 7, NombreServicio = "Tratamiento Moscas", Precio = 100},
                new Servicio {Id = 8, NombreServicio = "Tratamiento Mosquitos", Precio = 100},
            };
        }

        public static List<Trabajador> GetTrabajadors()
        {
            return new List<Trabajador>
            {
                new Trabajador {Id = 1, NombreCompleto = "Carlos Alberto", Categoria = Categoria.Jefe, Salario = 200},
                new Trabajador {Id = 2, NombreCompleto = "Juan Reyes", Categoria = Categoria.Gerente, Salario = 100},
                new Trabajador {Id = 3, NombreCompleto = "Felipe Rodriguez", Categoria = Categoria.Peon, Salario = 10},
                new Trabajador {Id = 4, NombreCompleto = "Gabriela Rodriguez", Categoria = Categoria.Peon, Salario = 10}
            };
        }
    }
}
