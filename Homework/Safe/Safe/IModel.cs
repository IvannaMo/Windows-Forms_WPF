﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Safe
{
    interface IModel
    {
        int Password { get; set; }


        bool CheckPassword(string password);
    }
}
