namespace ControlPlagas.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCompleto = c.String(maxLength: 256),
                        Telefono = c.String(maxLength: 13),
                        CorreoElectronico = c.String(maxLength: 256),
                        Direccion = c.String(maxLength: 256),
                        CodicoPostal = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreServicio = c.String(),
                        Precio = c.Int(nullable: false),
                        Factura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facturas", t => t.Factura_Id)
                .Index(t => t.Factura_Id);
            
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
                        Servicio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plagas", t => t.Plaga_Id)
                .ForeignKey("dbo.Servicios", t => t.Servicio_Id)
                .Index(t => t.Plaga_Id)
                .Index(t => t.Servicio_Id);
            
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
                "dbo.Trabajadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCompleto = c.String(),
                        Categoria = c.Int(nullable: false),
                        Salario = c.Double(nullable: false),
                        Servicio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Servicios", t => t.Servicio_Id)
                .Index(t => t.Servicio_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Facturas", "Cliente_Id", "dbo.Cliente");
            DropForeignKey("dbo.Trabajadors", "Servicio_Id", "dbo.Servicios");
            DropForeignKey("dbo.Recursoes", "Servicio_Id", "dbo.Servicios");
            DropForeignKey("dbo.Recursoes", "Plaga_Id", "dbo.Plagas");
            DropForeignKey("dbo.Servicios", "Factura_Id", "dbo.Facturas");
            DropIndex("dbo.Trabajadors", new[] { "Servicio_Id" });
            DropIndex("dbo.Recursoes", new[] { "Servicio_Id" });
            DropIndex("dbo.Recursoes", new[] { "Plaga_Id" });
            DropIndex("dbo.Servicios", new[] { "Factura_Id" });
            DropIndex("dbo.Facturas", new[] { "Cliente_Id" });
            DropTable("dbo.Trabajadors");
            DropTable("dbo.Plagas");
            DropTable("dbo.Recursoes");
            DropTable("dbo.Servicios");
            DropTable("dbo.Facturas");
            DropTable("dbo.Cliente");
        }
    }
}
