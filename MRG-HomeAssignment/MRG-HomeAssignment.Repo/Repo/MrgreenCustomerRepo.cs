using MRG_HomeAssignment.Lib;
using MRG_HomeAssignment.Lib.DomainClass;
using MRG_HomeAssignment.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRG_HomeAssignment.Repo.Repo
{
    public class MrgreenCustomerRepo : IMrgreenCustomerRepository
    {
        UserContext db = new UserContext();

        public IQueryable<mrgreenCustomer> All => db.MrgreenCustomers;

        public void Delete(int id)
        {
            db.MrgreenCustomers.Remove(Find(id));
            Save();
            Dispose();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public mrgreenCustomer Find(int id)
        {
            return db.MrgreenCustomers.Find(id);
        }

        public int Insert(mrgreenCustomer entity)
        {
            var existCust = Find(entity.Id);
            if (existCust == null)
                db.MrgreenCustomers.Add(entity);
            else
            {
                existCust.Id = entity.Id;
                existCust.Firstname = entity.Firstname;
                existCust.Lastname = entity.Lastname;
                existCust.Street = entity.Street;
                existCust.PostalCode = entity.PostalCode;
                existCust.City = entity.City;
                existCust.PersonalNumber = entity.PersonalNumber;
            }
            Save();
            return entity.Id;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(mrgreenCustomer entity)
        {
            var existCust = Find(entity.Id);
            if (existCust == null)
                db.MrgreenCustomers.Add(entity);
            else
            {
                existCust.Id = entity.Id;
                existCust.Firstname = entity.Firstname;
                existCust.Lastname = entity.Lastname;
                existCust.Street = entity.Street;
                existCust.PostalCode = entity.PostalCode;
                existCust.City = entity.City;
                existCust.PersonalNumber = entity.PersonalNumber;
            }
            Save();
        }
    }
}
