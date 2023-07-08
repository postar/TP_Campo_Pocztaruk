using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class STORY
    {
        private int idStory;

        public int IdStory
        {
            get { return idStory; }
            set { idStory = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int? points;

        public int? Points
        {
            get { return points; }
            set { points = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private List<BE.USER> stakeholders;

        public List<BE.USER> StakeHolders
        {
            get { return stakeholders; }
            set { stakeholders = value; }
        }

        private BE.USER reporter;

        public BE.USER Reporter
        {
            get { return reporter; }
            set { reporter = value; }
        }

        private BE.USER assignee;

        public BE.USER Assignee
        {
            get { return assignee; }
            set { assignee = value; }
        }

        private BE.STORY father;

        public BE.STORY Father
        {
            get { return father; }
            set { father = value; }
        }

        private BE.Project project;

        public BE.Project Project
        {
            get { return project; }
            set { project = value; }
        }

        private int? priority;

        public int? Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

    }
}