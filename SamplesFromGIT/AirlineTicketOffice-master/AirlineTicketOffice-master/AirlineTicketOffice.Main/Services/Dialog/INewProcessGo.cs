﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirlineTicketOffice.Main.Services.Dialog
{
    public interface INewProcessGo
    {
        bool startNewProcess(string path);
    }
}
