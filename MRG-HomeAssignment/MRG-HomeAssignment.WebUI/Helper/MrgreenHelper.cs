using MRG_HomeAssignment.Lib.DomainClass;
using MRG_HomeAssignment.Repo.Repo;
using MRG_HomeAssignment.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MRG_HomeAssignment.WebUI.Helper
{
    public class MrgreenHelper
    {
        MrgreenCustomerRepo repo = new MrgreenCustomerRepo();

        //Register new customer and converting from viewmodel to domain model, returns int to redirect to edit page after the new account is created
        public int Register(MrgreenCustomerViewModel model)
        {
            var dbCustomer = new mrgreenCustomer()
            {
                Id = model.Id,
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Street = model.Street,
                City = model.City,
                PostalCode = model.PostalCode,
                PersonalNumber = model.PersonalNumber
            };
            return repo.Insert(dbCustomer);
        }

        //Updating customer and converting from viewmodel to domain model
        public void Update(MrgreenCustomerViewModel model)
        {
            var dbCustomer = new mrgreenCustomer()
            {
                Id = model.Id,
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Street = model.Street,
                City = model.City,
                PostalCode = model.PostalCode,
                PersonalNumber = model.PersonalNumber
            };
            repo.Update(dbCustomer);
        }

        //delete customer
        public void Delete(int id)
        {
            repo.Delete(id);
        }

        //Finds a specific customer from db and converting to viewmodel
        public MrgreenCustomerViewModel FindById(int id)
        {
            var dbCust = repo.Find(id);
            var mrgCust = new MrgreenCustomerViewModel()
            {
                Id = dbCust.Id,
                Firstname = dbCust.Firstname,
                Lastname = dbCust.Lastname,
                Street = dbCust.Street,
                City = dbCust.City,
                PostalCode = dbCust.PostalCode,
                PersonalNumber = dbCust.PersonalNumber
            };
            return mrgCust;
        }

        //Fetches list from db and converting to viewmodel
        public List<MrgreenCustomerViewModel> mrgreenCustomers()
        {
            var dbList = repo.All.ToList();
            var modelList = new List<MrgreenCustomerViewModel>();
            foreach (var cust in dbList)
            {
                var mrgCust = new MrgreenCustomerViewModel()
                {
                    Id = cust.Id,
                    Firstname = cust.Firstname,
                    Lastname = cust.Lastname,
                    Street = cust.Street,
                    City = cust.City,
                    PostalCode = cust.PostalCode,
                    PersonalNumber = cust.PersonalNumber
                };
                modelList.Add(mrgCust);
            }
            return modelList.ToList();
        }
    }
}