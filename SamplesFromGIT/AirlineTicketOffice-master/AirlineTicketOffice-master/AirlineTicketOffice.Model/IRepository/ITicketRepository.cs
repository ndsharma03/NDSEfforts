﻿using AirlineTicketOffice.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AirlineTicketOffice.Model.IRepository
{
    public interface ITicketRepository : IBaseOperationRepository<AllTicketsModel>, IGetAllRepository<AllTicketsModel>
    {
        bool CheckConnection();
    }
}
