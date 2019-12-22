namespace bai1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Loi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHocPhans",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        giaoVienPhuTrach = c.String(),
                        hanMucSinhVien = c.String(),
                        maMonHoc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        maLopHocPhan = c.String(),
                        maSinhVien = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        tenMonHoc = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ten = c.String(),
                        hoDem = c.String(),
                        ngaySinh = c.DateTime(nullable: false),
                        diaChi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhViens");
            DropTable("dbo.MonHocs");
            DropTable("dbo.LopHocs");
            DropTable("dbo.LopHocPhans");
        }
    }
}
