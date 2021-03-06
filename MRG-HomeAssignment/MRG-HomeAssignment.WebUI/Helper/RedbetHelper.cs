﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MRG_HomeAssignment.Lib.DomainClass;
using MRG_HomeAssignment.Repo.Repo;
using MRG_HomeAssignment.WebUI.Models;

namespace MRG_HomeAssignment.WebUI.Helper
{
    public class RedbetHelper
    {
        RedbetCustomerRepo repo = new RedbetCustomerRepo();

        //Register new customer and converting from viewmodel to domain model, returns int to redirect to edit page after the new account is created
        public int Register(RedbetCustomerViewModel model)
        {
            var dbCustomer = new redbetCustomer()
            {
                Id = model.Id,
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Street = model.Street,
                City = model.City,
                PostalCode = model.PostalCode,
                FavoriteTeam = model.FavoriteTeam
            };
            return repo.Insert(dbCustomer);
        }

        //Updating customer and converting from viewmodel to domain model
        public void Update(RedbetCustomerViewModel model)
        {
            var dbCustomer = new redbetCustomer()
            {
                Id = model.Id,
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Street = model.Street,
                City = model.City,
                PostalCode = model.PostalCode,
                FavoriteTeam = model.FavoriteTeam
            };
            repo.Update(dbCustomer);
        }

        //delete customer
        public void Delete(int id)
        {
            repo.Delete(id);
        }

        //Finds a specific customer from db and converting to viewmodel
        public RedbetCustomerViewModel FindById(int id)
        {
            var dbCust = repo.Find(id);
            var redBetCust = new RedbetCustomerViewModel()
            {
                Id = dbCust.Id,
                Firstname = dbCust.Firstname,
                Lastname = dbCust.Lastname,
                Street = dbCust.Street,
                City = dbCust.City,
                PostalCode = dbCust.PostalCode,
                FavoriteTeam = dbCust.FavoriteTeam
            };
            return redBetCust;
        }

        //Fetches list from db and converting to viewmodel
        public List<RedbetCustomerViewModel> redbetCustomers()
        {
            var dbList = repo.All.ToList();
            var modelList = new List<RedbetCustomerViewModel>();
            foreach (var cust in dbList)
            {
                var redBetCust = new RedbetCustomerViewModel()
                {
                    Id = cust.Id,
                    Firstname = cust.Firstname,
                    Lastname = cust.Lastname,
                    Street = cust.Street,
                    City = cust.City,
                    PostalCode = cust.PostalCode,
                    FavoriteTeam = cust.FavoriteTeam
                };
                modelList.Add(redBetCust);
            }
            return modelList;
        }
    }
}