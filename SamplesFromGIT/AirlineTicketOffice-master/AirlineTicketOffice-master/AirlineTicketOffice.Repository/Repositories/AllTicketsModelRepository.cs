﻿using AirlineTicketOffice.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirlineTicketOffice.Model.Models;
using System.Linq.Expressions;
using System.Data.Entity;
using AirlineTicketOffice.Data;
using System.Diagnostics;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace AirlineTicketOffice.Repository.Repositories
{
    /// <summary>
    /// Repository for 'AllTicketsModel'.
    /// </summary>
    public sealed class AllTicketsModelRepository : BaseModelRepository<Ticket>, ITicketRepository
    {

        public AllTicketsModelRepository()
            : base()
        {
        }
        
        /// <summary>
        /// Check existing database.
        /// </summary>
        /// <returns></returns>
        public bool CheckConnection()
        {
            if (CheckExistDB())
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Add 'ticket' to the db.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(AllTicketsModel entity)
        {
            _methodName = "Add(AllTicketsModel entity) fail...";

            try
            {
                if (entity == null) return false;              

                _context.Tickets.Add(new Ticket
                {
                    TicketID = entity.TicketID,
                    FlightID = entity.FlightID,
                    PassengerID = entity.PassengerID,
                    CashierID = entity.CashierID,
                    RateID = entity.RateID,
                    SaleDate = entity.SaleDate,
                    TotalCost = entity.TotalCost
                });

                if (Save())
                {                       
                    return true;
                }

                DebugWrite(_methodName, String.Empty);
                return false;
            }
            catch (NullReferenceException ex)
            {
                DebugWrite(_methodName, ex.Message);
                return false;
            }
            catch (ArgumentException ex)
            {
                DebugWrite(_methodName, ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                DebugWrite(_methodName, ex.Message);
                return false;
            }

        }     

        /// <summary>
        /// Get all 'ticket' from db.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AllTicketsModel> GetAll()
        {
            _methodName = "IEnumerable<AllTicketsModel> GetAll() fail...";

            try
            {
                _context.Database.Log = (s => Console.WriteLine(s));

                return _context.Tickets.Include(c => c.Cashier).AsNoTracking().ToArray().Select((Ticket t) =>
                {
                    return new AllTicketsModel
                    {
                        TicketID = t.TicketID,
                        FlightID = t.FlightID,
                        PassengerID = t.PassengerID,
                        CashierID = t.CashierID,
                        RateID = t.RateID,
                        SaleDate = t.SaleDate,
                        TotalCost = t.TotalCost,
                        Cashier = new CashierModel
                        {
                            CashierID = t.Cashier.CashierID,
                            NumberOfOffices = t.Cashier.NumberOfOffices,
                            FullName = t.Cashier.FullName
                        }

                    };
                });
            }
            catch (NullReferenceException ex)
            {
                DebugWrite(_methodName, ex.Message);
                return null;
            }
            catch (ArgumentException ex)
            {
                DebugWrite(_methodName, ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                DebugWrite(_methodName, ex.Message);
                return null;
            }
          
        }     

        public bool Remove(AllTicketsModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(AllTicketsModel entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
