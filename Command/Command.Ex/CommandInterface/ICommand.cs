﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Ex.CommandInterface
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}

