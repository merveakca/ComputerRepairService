using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairService.Models;
public class ComputerRepairDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-D84DF12\\SQLEXPRESS01; Database=ComputerRepairDB; Trusted_Connection=true; TrustServerCertificate=True");
    }

    public DbSet<Customer> Customer { get; set; }
    public DbSet<ServiceRecord> ServiceRecords { get; set; }
    public DbSet<SparePart> SpareParts { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<ServiceStatus> ServiceStatuses { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
}
