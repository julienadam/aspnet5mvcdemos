using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace IoCDemo.Models
{
    public class EfSuppliersRepository : ISuppliersRepository
    {
        private readonly NorthwindContext db;

        public EfSuppliersRepository(NorthwindContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public async Task DeleteById(int id)
        {
            db.Suppliers.Remove(await GetById(id));
            await db.SaveChangesAsync();
        }

        public async Task<Supplier> GetById(int id)
        {
            return await db.Suppliers.FirstOrDefaultAsync(s => s.SupplierID == id);
        }

        public async Task Update(Supplier supplier)
        {
            db.Entry(supplier).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async void Create(Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            await db.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Supplier>> GetAll()
        {
            return await db.Suppliers.ToListAsync();
        }
    }
}