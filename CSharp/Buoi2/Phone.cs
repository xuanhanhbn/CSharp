﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap.BaiTap2
{
    abstract class Phone
    {
        public abstract void InsertPhone(String name, String phone);
        public abstract void RemovePhone(String name);
        public abstract void UpdatePhone(String name, String newphone);
        public abstract void SearchPhone(String name);
        public abstract void Sort();
    }
}
