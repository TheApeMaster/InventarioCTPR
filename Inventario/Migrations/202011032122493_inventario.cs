namespace Inventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inventario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bienes",
                c => new
                    {
                        numeroDePatrimonio = c.String(nullable: false, maxLength: 128),
                        codigoDeBarras = c.String(nullable: false),
                        descripcion = c.String(maxLength: 30),
                        anadidoPor = c.String(),
                        numeroDeFactura = c.String(nullable: false),
                        ley = c.String(),
                        marca = c.String(maxLength: 20),
                        modelo = c.String(maxLength: 20),
                        serie = c.String(maxLength: 20),
                        idEspecialidad = c.String(maxLength: 128),
                        ubicacion = c.String(maxLength: 3),
                        estado = c.String(nullable: false),
                        condicion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.numeroDePatrimonio)
                .ForeignKey("dbo.Especialidads", t => t.idEspecialidad)
                .Index(t => t.idEspecialidad);
            
            CreateTable(
                "dbo.Especialidads",
                c => new
                    {
                        idEspecialidad = c.String(nullable: false, maxLength: 128),
                        nombreEspecialidad = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.idEspecialidad);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bienes", "idEspecialidad", "dbo.Especialidads");
            DropIndex("dbo.Bienes", new[] { "idEspecialidad" });
            DropTable("dbo.Especialidads");
            DropTable("dbo.Bienes");
        }
    }
}
