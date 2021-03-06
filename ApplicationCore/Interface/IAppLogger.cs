﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interface
{
    public interface IAppLogger<T>
    {
        void LogInformation(string message, params object[] args);
        void LogWarnning(string message, params object[] args);
    }
}
