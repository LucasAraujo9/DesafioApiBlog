
using ApiBlog.Data;
using ApiBlog.Interfaces;
using ApiBlog.Repositories;
using ApiBlog.Services;
using Microsoft.EntityFrameworkCore;

namespace ApiBlog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IBlogPostService, BlogPostService>();
            builder.Services.AddScoped<IBlogPostRepository, BlogPostRepository>();

            builder.Services.AddScoped<ICommentService, CommentService>();
            builder.Services.AddScoped<ICommentRepository, CommentRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
