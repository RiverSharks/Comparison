﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison.CustomExceptions
{
    class FileExistException : Exception
    {
        public FileExistException(string message)
        : base(message)
        { }
    }
}

