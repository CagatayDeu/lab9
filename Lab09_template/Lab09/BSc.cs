﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{


    [Serializable]
    class BSc : Student
    {
        string name, surname;
        int no;

        public BSc(string name, string surname, int no) : base(name, surname, no)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
        }
    }
}