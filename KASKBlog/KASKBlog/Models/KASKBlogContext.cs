using System.Data.Entity;

namespace KASKBlog.Models
{
    public class KASKBlogContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<KASKBlog.Models.KASKBlogContext>());

        // Note: This context is used by the Entity Framework to help with object-relational mapping between database and model.

        public KASKBlogContext() : base("name=KASKBlogContext")
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
