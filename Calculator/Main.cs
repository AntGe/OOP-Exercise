﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MainClass
    {
        static void Main(string[] args)
        {
            BasicCommandDispatcher dispatcher = new BasicCommandDispatcher();
            Core core = new Core(dispatcher);
            core.Run();

        }
    }
}
