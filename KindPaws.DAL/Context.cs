using KindPaws.Core;
using KindPaws.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace KindPaws.DAL;

public class Context : DbContext
{
    public DbSet<RoleDTO> Roles { get; set; }
    public DbSet<UserDTO> Users { get; set; }
    public DbSet<ShelterDTO> Shelters { get; set; }
    public DbSet<FeedbackDTO> Feedbacks { get; set; }
    public DbSet<AnimalDTO> Animals { get; set; }
    public DbSet<AnimalTypeDTO> Types { get; set; }
    public DbSet<TagDTO> Tags { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Options.CONNECTION_INFO);
    }
}