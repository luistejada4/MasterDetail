namespace MasterDetail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstModels : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cursoes", newName: "Curso");
            RenameTable(name: "dbo.Estudiantes", newName: "Estudiante");
            RenameTable(name: "dbo.EstudianteCursoes", newName: "EstudianteCurso");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EstudianteCurso", newName: "EstudianteCursoes");
            RenameTable(name: "dbo.Estudiante", newName: "Estudiantes");
            RenameTable(name: "dbo.Curso", newName: "Cursoes");
        }
    }
}
