﻿using HelpDeskDemo.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Common
{
    public interface IRepositoryManager
    {
        IEquipmentRepository Equipment { get; }



    }
}
