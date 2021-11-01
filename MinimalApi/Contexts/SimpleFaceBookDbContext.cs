using Microsoft.EntityFrameworkCore;
using MinimalApi.Entities;

namespace MinimalApi.Contexts
{
    public class SimpleFaceBookDbContext : DbContext
    {
        public SimpleFaceBookDbContext(DbContextOptions<SimpleFaceBookDbContext> options) : base(options)
        { 
        }
        //public DbSet<ResetPassword> ResetPasswords { get; set; }
        public DbSet<Post> Posts { get; set; }
        //public DbSet<LikePost> Likes { get; set; }
        //public DbSet<CommentPost> CommentPosts { get; set; }
        
    }
}
