using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Test.Models.Article;
using Test.Models.Comment;
using Test.Models.Image;
using Test.Models.Like;
using Test.Models.Product;
using Test.Models.Qs;
using Test.Models.ReplyComment;
using Test.Models.User;

namespace Test.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        #region DbSet
        public DbSet<UserModel>  UserModels { get; set; }

        public DbSet<ProductModel> ProductModels{ get; set; }
        public DbSet<CommentModel> CommentModels { get; set; }
        public DbSet<ReplyCommentModel> ReplyCommentModels{ get; set; }

        public DbSet<ArticleModel> ArticleModels { get; set; }
        public DbSet<CommentArticleModel> CommentArticleModels { get; set; }
        public DbSet<ReplyCommentArticleModel> ReplyCommentArticleModels { get; set; }

        public DbSet<ProductCatagoryModel> ProductCatagoryModels { get; set; }
        public DbSet<ProductCatagorySelectedModel> ProductCatagorySelectedModels { get; set; }

        public DbSet<QsModel> QsModels { get; set; }
        public DbSet<CommentQsModel> CommentQsModels { get; set; }
        public DbSet<ReplyCommentQsModel> ReplyCommentQsModels { get; set; }

        public DbSet<QsCategoryModel> QsCategoryModels { get; set; }
        public DbSet<QsCategorySelectedModel> QsCategorySelectedModels { get; set; }

        public DbSet<ImageModel> ImageModels { get; set; }
        public DbSet<GalleriesModel> GalleriesModels{ get; set; }

        public DbSet<LikeProductModel> LikeProductModels { get; set; }
        public DbSet<LikeCommentModel> LikeCommentModels { get; set; }
        public DbSet<LikeReplyCommentProductModel> LikeReplyCommentProductModels { get; set; }


        public DbSet<LikeArticleModel> LikeArticleModels{ get; set; }
        public DbSet<LikeCommentArticleModel> LikeCommentArticleModels { get; set; }
        public DbSet<LikeReplyCommentArticleModel> LikeReplyCommentArticleModels { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region User
            //-----------------User To Product------------------------//
            //User to Comment
            modelBuilder.Entity<UserModel>()
                .HasMany(c=>c.CommentModels)
                .WithOne(u=>u.UserModel)
                .HasForeignKey(c=>c.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            //User to reply comment product
            modelBuilder.Entity<UserModel>()
                .HasMany(r=>r.ReplyCommentModels)
                .WithOne(u=>u.UserModel)
                .HasForeignKey(r=>r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            //User to Product
            modelBuilder.Entity<UserModel>()
                .HasMany(p => p.ProductModels)
                .WithOne(u => u.UserModel)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            //-----------------User To Article------------------------//
            //User to Article
            modelBuilder.Entity<UserModel>()
                .HasMany(a => a.ArticleModels)
                .WithOne(u => u.UserModel)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            //User to Comment Article
            modelBuilder.Entity<UserModel>()
                .HasMany(c => c.CommentArticleModels)
                .WithOne(u => u.UserModel)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            //User to Reply Comment Article
            modelBuilder.Entity<UserModel>()
               .HasMany(r => r.ReplyCommentArticleModels)
               .WithOne(u => u.UserModel)
               .HasForeignKey(r => r.UserId)
               .OnDelete(DeleteBehavior.Restrict);
            //-----------------User To Qs------------------------//
            //User to Question
            modelBuilder.Entity<UserModel>()
                .HasMany(q => q.QsModels)
                .WithOne(u=>u.UserModel) 
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            //User to QsComment
            modelBuilder.Entity<UserModel>()
                .HasMany(q => q.CommentQsModels)
                .WithOne(u => u.UserModel)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            //User to Reply QsComment
            modelBuilder.Entity<UserModel>()
                .HasMany(q => q.ReplyCommentQsModels)
                .WithOne(u => u.UserModel)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            //-----------------User To Like------------------------//
            #region User Like to Article
            //User to like Article
            modelBuilder.Entity<UserModel>()
               .HasMany(l => l.LikeArticleModels)
               .WithOne(u => u.UserModel)
               .HasForeignKey(r => r.UserId)
               .OnDelete(DeleteBehavior.Restrict);
            //User to like Comment Article
            modelBuilder.Entity<UserModel>()
               .HasMany(l => l.LikeCommentArticleModels)
               .WithOne(u => u.UserModel)
               .HasForeignKey(r => r.UserId)
               .OnDelete(DeleteBehavior.Restrict);
            //User to like Reply Comment Article
            modelBuilder.Entity<UserModel>()
               .HasMany(l => l.LikeReplyCommentArticleModels)
               .WithOne(u => u.UserModel)
               .HasForeignKey(r => r.UserId)
               .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region User Like to Product
            //User to like Product
            modelBuilder.Entity<UserModel>()
               .HasMany(l => l.LikeProductModels)
               .WithOne(u => u.UserModel)
               .HasForeignKey(r => r.UserId)
               .OnDelete(DeleteBehavior.Restrict);
            //User to like Comment Product
            modelBuilder.Entity<UserModel>()
              .HasMany(l => l.LikeCommentModels)
              .WithOne(u => u.UserModel)
              .HasForeignKey(r => r.UserId)
              .OnDelete(DeleteBehavior.Restrict);
            //User to like Reply Comment Product
            modelBuilder.Entity<UserModel>()
             .HasMany(l => l.LikeReplyCommentProductModels)
             .WithOne(u => u.UserModel)
             .HasForeignKey(r => r.UserId)
             .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region User Like To Qs
            //User to Like QsModel
            modelBuilder.Entity<UserModel>()
                .HasMany(l=>l.LikeQsModels)
                .WithOne(u => u.UserModel)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            //User To like QsComment
            modelBuilder.Entity<UserModel>()
                .HasMany(l=>l.LikeQsCommentModels)
                .WithOne(u => u.UserModel)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            //User To Like ReplyQsComment
            modelBuilder.Entity<UserModel>()
              .HasMany(l => l.LikeReplyCommentQsModels)
              .WithOne(u => u.UserModel)
              .HasForeignKey(r => r.UserId)
              .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #endregion

            #region Product
            //Product to Comment
            modelBuilder.Entity<ProductModel>()
                .HasMany(c => c.commentModels)
                .WithOne(p => p.ProductModel)
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            //Product to product selected
            modelBuilder.Entity<ProductModel>()
              .HasMany(p => p.ProductCatagorySelectedModels)
              .WithOne(c => c.ProductModel)
              .HasForeignKey(p => p.ProductId)
              .OnDelete(DeleteBehavior.Restrict);
            //Product to Like
            modelBuilder.Entity<ProductModel>()
                .HasMany(l => l.LikeProductModels)
                .WithOne(p => p.ProductModel)
                .HasForeignKey(l => l.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            //Product Category to product selected
            modelBuilder.Entity<ProductCatagoryModel>()
               .HasMany(p => p.ProductCatagorySelectedModels)
               .WithOne(c => c.ProductCatagoryModel)
               .HasForeignKey(p => p.CatagoryId)
               .OnDelete(DeleteBehavior.Restrict);
            //Product to Galleries
            modelBuilder.Entity<ProductModel>()
                .HasMany(p => p.GalleriesModels)
                .WithOne(g => g.ProductModel)
                .HasForeignKey(g => g.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            //Image to Galleries
            modelBuilder.Entity<ImageModel>()
               .HasMany(i => i.GalleriesModels)
               .WithOne(g => g.ImageModel)
               .HasForeignKey(i => i.ImageId)
               .OnDelete(DeleteBehavior.Restrict);
            //Comment Product to Like
            modelBuilder.Entity<CommentModel>()
                .HasMany(l => l.LikeCommentModels)
                .WithOne(c => c.CommentModel)
                .HasForeignKey(l => l.CommentId)
                .OnDelete(DeleteBehavior.Restrict);
            //Comment to Reply
            modelBuilder.Entity<CommentModel>()
               .HasMany(r => r.ReplyCommentModels)
               .WithOne(c => c.CommentModel)
               .HasForeignKey(r => r.CommentId)
               .OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Article
            //Article to Comment
            modelBuilder.Entity<ArticleModel>()
              .HasMany(c => c.CommentArticleModels)
              .WithOne(a => a.ArticleModel)
              .HasForeignKey(c => c.ArticleId)
              .OnDelete(DeleteBehavior.Restrict);
            //Article to Like
            modelBuilder.Entity<ArticleModel>()
                .HasMany(a => a.LikeArticleModels)
                .WithOne(l => l.ArticleModel)
                .HasForeignKey(a=>a.ArticleId)
                .OnDelete(DeleteBehavior.Restrict);
            //Comment to like
            modelBuilder.Entity<CommentArticleModel>()
                .HasMany(c=>c.LikeCommentArticleModels)
                .WithOne(l=>l.CommentArticleModel)
                .HasForeignKey(c=>c.CommentArticleId)
                .OnDelete(DeleteBehavior.Restrict);
            //Comment to Reply
            modelBuilder.Entity<CommentArticleModel>()
               .HasMany(r=>r.ReplyCommentArticleModels)
               .WithOne(l => l.CommentArticleModel)
               .HasForeignKey(r => r.CommentArticleId)
               .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Question
            //Qs To Comment
            modelBuilder.Entity<QsModel>()
                .HasMany(c => c.CommentQsModels)
                .WithOne(q => q.QsModel)
                .HasForeignKey(c => c.QsId)
                .OnDelete(DeleteBehavior.Restrict);
            //Qs To Like
            modelBuilder.Entity<QsModel>()
                .HasMany(c => c.LikeQsModels)
                .WithOne(q => q.QsModel)
                .HasForeignKey(c => c.QsId)
                .OnDelete(DeleteBehavior.Restrict);
            //QsComment To Reply
            modelBuilder.Entity<CommentQsModel>()
                .HasMany(r => r.ReplyCommentQsModels)
                .WithOne(c=>c.CommentQsModel)
                .HasForeignKey(r=>r.CommentQsId)
                .OnDelete(DeleteBehavior.Restrict);
            //QsComment To Like
            modelBuilder.Entity<CommentQsModel>()
                .HasMany(l=>l.LikeQsCommentModels)
                .WithOne(c=>c.CommentQsModel)
                .HasForeignKey(l=>l.CommentQsId)
                .OnDelete(DeleteBehavior.Restrict);
            //ReplyQs To Like
            modelBuilder.Entity<ReplyCommentQsModel>()
                .HasMany(l => l.LikeReplyCommentQsModels)
                .WithOne(c => c.ReplyCommentQsModel)
                .HasForeignKey(l => l.ReplyCommentQsId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}
