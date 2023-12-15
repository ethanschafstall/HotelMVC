using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC
{
    public class Task
    {
        private string _id;
        private string _name;
        private string _description;
        private string _status;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
