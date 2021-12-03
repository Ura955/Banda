﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda
{
    class Driver : IGangMember 
    {
        public IRingleader _ringleader { get; set; }
        public string Name { get; set; } = "Водитель";

        public Driver(IRingleader ringleader)
        {
            _ringleader = ringleader;
        }

        public void Ready(IRingleader ringleader)
        {
            if ((ringleader as Ringleader).State == 1)
                _ringleader.BandaReady(this);
        }
    }
}
