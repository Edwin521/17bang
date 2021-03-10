namespace BLL.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Level = c.Int(nullable: false),
                        InviterId = c.Int(),
                        MyInviterCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.InviterId)
                .Index(t => t.InviterId);
            
            CreateTable(
                "dbo.BMoneys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerId = c.Int(nullable: false),
                        Latestime = c.DateTime(nullable: false),
                        Detail = c.String(),
                        Freezing = c.Int(nullable: false),
                        Change = c.Int(nullable: false),
                        LeftBMoney = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Summary = c.String(),
                        Title = c.String(),
                        Body = c.String(),
                        PublishTime = c.DateTime(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PublisTime = c.DateTime(nullable: false),
                        Content = c.String(),
                        Agree = c.Int(nullable: false),
                        DisAgree = c.Int(nullable: false),
                        ReplyId = c.Int(),
                        AuthorId = c.Int(nullable: false),
                        BelongArticleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Articles", t => t.BelongArticleId, cascadeDelete: true)
                .ForeignKey("dbo.Comments", t => t.ReplyId)
                .Index(t => t.ReplyId)
                .Index(t => t.AuthorId)
                .Index(t => t.BelongArticleId);
            
            CreateTable(
                "dbo.Keywords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Word = c.String(),
                        Used = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Problems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Body = c.String(),
                        NeedRemoteHelp = c.Boolean(nullable: false),
                        RewardMoney = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        PublishTime = c.DateTime(nullable: false),
                        Author_Id = c.Int(),
                        HelpFrom_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .ForeignKey("dbo.Users", t => t.HelpFrom_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.HelpFrom_Id);
            
            CreateTable(
                "dbo.KeywordArticles",
                c => new
                    {
                        Keyword_Id = c.Int(nullable: false),
                        Article_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Keyword_Id, t.Article_Id })
                .ForeignKey("dbo.Keywords", t => t.Keyword_Id, cascadeDelete: true)
                .ForeignKey("dbo.Articles", t => t.Article_Id, cascadeDelete: true)
                .Index(t => t.Keyword_Id)
                .Index(t => t.Article_Id);
            
            CreateTable(
                "dbo.ProblemKeywords",
                c => new
                    {
                        Problem_Id = c.Int(nullable: false),
                        Keyword_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Problem_Id, t.Keyword_Id })
                .ForeignKey("dbo.Problems", t => t.Problem_Id, cascadeDelete: true)
                .ForeignKey("dbo.Keywords", t => t.Keyword_Id, cascadeDelete: true)
                .Index(t => t.Problem_Id)
                .Index(t => t.Keyword_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProblemKeywords", "Keyword_Id", "dbo.Keywords");
            DropForeignKey("dbo.ProblemKeywords", "Problem_Id", "dbo.Problems");
            DropForeignKey("dbo.Problems", "HelpFrom_Id", "dbo.Users");
            DropForeignKey("dbo.Problems", "Author_Id", "dbo.Users");
            DropForeignKey("dbo.KeywordArticles", "Article_Id", "dbo.Articles");
            DropForeignKey("dbo.KeywordArticles", "Keyword_Id", "dbo.Keywords");
            DropForeignKey("dbo.Comments", "ReplyId", "dbo.Comments");
            DropForeignKey("dbo.Comments", "BelongArticleId", "dbo.Articles");
            DropForeignKey("dbo.Comments", "AuthorId", "dbo.Users");
            DropForeignKey("dbo.Articles", "Author_Id", "dbo.Users");
            DropForeignKey("dbo.BMoneys", "OwnerId", "dbo.Users");
            DropForeignKey("dbo.Users", "InviterId", "dbo.Users");
            DropIndex("dbo.ProblemKeywords", new[] { "Keyword_Id" });
            DropIndex("dbo.ProblemKeywords", new[] { "Problem_Id" });
            DropIndex("dbo.KeywordArticles", new[] { "Article_Id" });
            DropIndex("dbo.KeywordArticles", new[] { "Keyword_Id" });
            DropIndex("dbo.Problems", new[] { "HelpFrom_Id" });
            DropIndex("dbo.Problems", new[] { "Author_Id" });
            DropIndex("dbo.Comments", new[] { "BelongArticleId" });
            DropIndex("dbo.Comments", new[] { "AuthorId" });
            DropIndex("dbo.Comments", new[] { "ReplyId" });
            DropIndex("dbo.Articles", new[] { "Author_Id" });
            DropIndex("dbo.BMoneys", new[] { "OwnerId" });
            DropIndex("dbo.Users", new[] { "InviterId" });
            DropTable("dbo.ProblemKeywords");
            DropTable("dbo.KeywordArticles");
            DropTable("dbo.Problems");
            DropTable("dbo.Keywords");
            DropTable("dbo.Comments");
            DropTable("dbo.Articles");
            DropTable("dbo.BMoneys");
            DropTable("dbo.Users");
        }
    }
}
