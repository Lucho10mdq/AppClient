﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Repository
{
    interface IClientRepository
    {
        void Add(Client oClient);
    }
}
