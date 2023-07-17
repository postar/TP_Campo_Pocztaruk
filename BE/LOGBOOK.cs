using System;

namespace BE
{
    public class LOGBOOK
    {
        private string User;
        private DateTime Date;
        private string Action;

        public string user { get => User; set => User = value; }
        public DateTime date { get => Date; set => Date = value; }
        public string action { get => Action; set => Action = value; }

    }
}