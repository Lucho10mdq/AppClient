﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    interface IPackage
    {
        int AddPackage(TouristPackage oTouristPackage);
        List<TouristPackage> GetPackage();
        int ModifyPackage(TouristPackage oTouristPackage);
    }
}
