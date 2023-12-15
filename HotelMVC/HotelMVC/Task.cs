using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC
{
    public class Task
    {
        private int _id;
        private string _name;
        private string _description;
        private string _status;
        private DateTime _dateCreated;
        private DateTime _dateStarted;
        private DateTime _dateFinished;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string Status { get => _status; set => _status = value; }
        public DateTime DateCreated { get => _dateCreated; set => _dateCreated = value; }
        public DateTime DateStarted { get => _dateStarted; set => _dateStarted = value; }
        public DateTime DateFinished { get => _dateFinished; set => _dateFinished = value; }
    }
}
