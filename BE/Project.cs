﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Project
    {
        public int Epics
        {
            get => default;
            set
            {
            }
        }

        public int State
        {
            get => default;
            set
            {
            }
        }

        public int Cost
        {
            get => default;
            set
            {
            }
        }

        private List<Requirement> requirements;

        public List<Requirement> Requirements
        {
            get { return requirements; }
            set { requirements = value; }
        }


        public void CalculateCost()
        {
            throw new System.NotImplementedException();
        }

        public int Responsible
        {
            get => default;
            set
            {
            }
        }
    }
}