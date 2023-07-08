using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Story
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int points;

        public int Points
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

        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}