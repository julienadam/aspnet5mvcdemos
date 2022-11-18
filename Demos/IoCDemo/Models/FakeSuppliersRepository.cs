using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Bogus;

namespace IoCDemo.Models
{
    public class FakeSuppliersRepository : ISuppliersRepository
    {
        private readonly Dictionary<int, Supplier> db = new Dictionary<int, Supplier>();

        public FakeSuppliersRepository() : this(25)
        {
        }

        private FakeSuppliersRepository(int count)
        {
            var suppliers = new Faker<Supplier>()
                .RuleFor(s => s.CompanyName, f => f.Company.CompanyName())
                .RuleFor(s => s.ContactName, f => f.Person.FullName)
                .RuleFor(s => s.Address, f => f.Address.StreetAddress())
                .RuleFor(s => s.City, f => f.Address.City())
                .RuleFor(s => s.ContactTitle, f => f.Name.JobTitle())
                .RuleFor(s => s.Country, f => f.Address.Country())
                .RuleFor(s => s.Fax, f => f.Phone.PhoneNumber())
                .RuleFor(s => s.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(s => s.HomePage, f => f.Person.Website)
                .RuleFor(s => s.PostalCode, f => f.Address.ZipCode())
                .RuleFor(s => s.Region, f => f.Address.State());

            for(int i = 0; i < count; i++)
            {
                Create(suppliers.Generate());
            }
        }

        public async Task DeleteById(int id)
        {
            db.Remove(id);
        }

        public async Task<Supplier> GetById(int id)
        {
            db.TryGetValue(id, out Supplier value);
            return value;
        }

        public async Task Update(Supplier supplier)
        {
            db[supplier.SupplierID] = supplier;
        }

        public void Create(Supplier supplier)
        {
            int id = db.Count;
            supplier.SupplierID = id;
            db.Add(id, supplier);
        }

        public async Task<IReadOnlyCollection<Supplier>> GetAll()
        {
            return new ReadOnlyCollection<Supplier>(db.Values.ToList());
        }
    }
}
