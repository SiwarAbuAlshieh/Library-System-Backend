﻿using LibrarySystem.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Repository
{
    public interface IJWTRepository
    {
        Login Auth(Login login);
    }
}
