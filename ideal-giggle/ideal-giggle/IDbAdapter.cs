﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ideal_giggle
{
    public interface IDbAdapter
    {
        public void InsertToTable<T>(T table);
  
    }
}
