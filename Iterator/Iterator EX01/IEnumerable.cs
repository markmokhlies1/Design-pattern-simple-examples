﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_EX01
{
    public interface IEnumerable <T>
    {
        IIterator<T> GetIterator();
    }
}
