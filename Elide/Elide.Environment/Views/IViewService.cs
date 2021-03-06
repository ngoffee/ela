﻿using System;
using System.Collections.Generic;
using Elide.Core;

namespace Elide.Environment.Views
{
    public interface IViewService : IExtService
    {
        bool IsViewActive(string key);

        string GetActiveViewKey(ViewType type);

        IView GetView(string key);

        bool OpenView(string key);

        bool CloseView(string key);
    }
}
