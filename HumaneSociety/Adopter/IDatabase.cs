﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopter
{
    interface IDatabase
    {
        void OpenConnection();
        void CloseConnection();
    }
}