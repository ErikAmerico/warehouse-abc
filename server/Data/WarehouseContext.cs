using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Data;

public class WarehouseContext : DbContext
{
    public WarehouseContext(DbContextOptions<WarehouseContext> options): base(options){ }

    public DbSet<Warehouse> Warehouses => Set<Warehouse>();
    public DbSet<Floor> Floors => Set<Floor>();
    public DbSet<Area> Areas => Set<Area>();
    public DbSet<Row> Rows => Set<Row>();
    public DbSet<Bay> Bays => Set<Bay>();
    public DbSet<Item> Items => Set<Item>();
    public DbSet<Owner> Owners => Set<Owner>();
}
