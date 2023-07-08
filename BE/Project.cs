﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Project
    {
        private int idProject;

        public int IdProject
        {
            get { return idProject; }
            set { idProject = value; }
        }

        private string projectName;

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        private USER client;

        public USER Client
        {
            get { return client; }
            set { client = value; }
        }

        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        private int cost;

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private USER responsible;

        public USER Responsible
        {
            get { return responsible; }
            set { responsible = value; }
        }

        private USER pm;

        public USER PM
        {
            get { return pm; }
            set { pm = value; }
        }

        private List<STORY> epics;

        public List<STORY> Epics
        {
            get { return epics; }
            set { epics = value; }
        }

        private string decription;

        public string Description
        {
            get { return decription; }
            set { decription = value; }
        }

    }
}