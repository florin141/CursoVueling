namespace ControlPlagas.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Servicio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreServicio = c.String(nullable: false, maxLength: 128),
                        Precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Precio = c.Single(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCompleto = c.String(nullable: false, maxLength: 256),
                        Telefono = c.String(nullable: false, maxLength: 15),
                        CorreoElectronico = c.String(nullable: false, maxLength: 256),
                        Direccion = c.String(maxLength: 512),
                        CodicoPostal = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recursoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreRecurso = c.String(),
                        Coste = c.Single(nullable: false),
                        Unidad = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Plaga_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plagas", t => t.Plaga_Id)
                .Index(t => t.Plaga_Id);
            
            CreateTable(
                "dbo.Plagas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreComun = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trabajador",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCompleto = c.String(nullable: false, maxLength: 128),
                        Categoria = c.Int(nullable: false),
                        Salario = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServicioFactura",
                c => new
                    {
                        IdServicio = c.Int(nullable: false),
                        IdFactura = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdServicio, t.IdFactura })
                .ForeignKey("dbo.Servicio", t => t.IdServicio, cascadeDelete: true)
                .ForeignKey("dbo.Factura", t => t.IdFactura, cascadeDelete: true)
                .Index(t => t.IdServicio)
                .Index(t => t.IdFactura);
            
            CreateTable(
                "dbo.ServicioRecurso",
                c => new
                    {
                        IdServicio = c.Int(nullable: false),
                        IdRecurso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdServicio, t.IdRecurso })
                .ForeignKey("dbo.Servicio", t => t.IdServicio, cascadeDelete: true)
                .ForeignKey("dbo.Recursoes", t => t.IdRecurso, cascadeDelete: true)
                .Index(t => t.IdServicio)
                .Index(t => t.IdRecurso);
            
            CreateTable(
                "dbo.ServicioTrabajador",
                c => new
                    {
                        IdServicio = c.Int(nullable: false),
                        IdTrabajador = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdServicio, t.IdTrabajador })
                .ForeignKey("dbo.Servicio", t => t.IdServicio, cascadeDelete: true)
                .ForeignKey("dbo.Trabajador", t => t.IdTrabajador, cascadeDelete: true)
                .Index(t => t.IdServicio)
                .Index(t => t.IdTrabajador);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServicioTrabajador", "IdTrabajador", "dbo.Trabajador");
            DropForeignKey("dbo.ServicioTrabajador", "IdServicio", "dbo.Servicio");
            DropForeignKey("dbo.ServicioRecurso", "IdRecurso", "dbo.Recursoes");
            DropForeignKey("dbo.ServicioRecurso", "IdServicio", "dbo.Servicio");
            DropForeignKey("dbo.Recursoes", "Plaga_Id", "dbo.Plagas");
            DropForeignKey("dbo.ServicioFactura", "IdFactura", "dbo.Factura");
            DropForeignKey("dbo.ServicioFactura", "IdServicio", "dbo.Servicio");
            DropForeignKey("dbo.Factura", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.ServicioTrabajador", new[] { "IdTrabajador" });
            DropIndex("dbo.ServicioTrabajador", new[] { "IdServicio" });
            DropIndex("dbo.ServicioRecurso", new[] { "IdRecurso" });
            DropIndex("dbo.ServicioRecurso", new[] { "IdServicio" });
            DropIndex("dbo.ServicioFactura", new[] { "IdFactura" });
            DropIndex("dbo.ServicioFactura", new[] { "IdServicio" });
            DropIndex("dbo.Recursoes", new[] { "Plaga_Id" });
            DropIndex("dbo.Factura", new[] { "ClienteId" });
            DropTable("dbo.ServicioTrabajador");
            DropTable("dbo.ServicioRecurso");
            DropTable("dbo.ServicioFactura");
            DropTable("dbo.Trabajador");
            DropTable("dbo.Plagas");
            DropTable("dbo.Recursoes");
            DropTable("dbo.Cliente");
            DropTable("dbo.Factura");
            DropTable("dbo.Servicio");
        }
    }
}
