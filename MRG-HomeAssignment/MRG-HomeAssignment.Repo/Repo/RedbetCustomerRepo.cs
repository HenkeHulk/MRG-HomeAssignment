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
    public class RedbetCustomerRepo : IRedBetCustomerRepository
    {
        UserContext db = new UserContext();
        public IQueryable<redbetCustomer> All => db.RedbetCustomers;

        public void Delete(int id)
        {
            db.RedbetCustomers.Remove(Find(id));
            Save();
            Dispose();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public redbetCustomer Find(int id)
        {
            return db.RedbetCustomers.Find(id);
        }

        public int Insert(redbetCustomer entity)
        {
            var existCust = Find(entity.Id);
            if (existCust == null)
                db.RedbetCustomers.Add(entity);
            else
            {
                existCust.Id = entity.Id;
                existCust.Firstname = entity.Firstname;
                existCust.Lastname = entity.Lastname;
                existCust.Street = entity.Street;
                existCust.PostalCode = entity.PostalCode;
                existCust.City = entity.City;
                existCust.FavoriteTeam = entity.FavoriteTeam; 
            }
            Save();
            return entity.Id;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(redbetCustomer entity)
        {
            var existCust = Find(entity.Id);
            if (existCust == null)
                db.RedbetCustomers.Add(entity);
            else
            {
                existCust.Id = entity.Id;
                existCust.Firstname = entity.Firstname;
                existCust.Lastname = entity.Lastname;
                existCust.Street = entity.Street;
                existCust.PostalCode = entity.PostalCode;
                existCust.City = entity.City;
                existCust.FavoriteTeam = entity.FavoriteTeam;
            }
            Save();
        }
    }
}
