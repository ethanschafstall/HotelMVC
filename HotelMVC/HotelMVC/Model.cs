using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace HotelMVC
{
    public class Model
    {
        private Controller _controller;

        public Controller Controller { get => _controller; set => _controller = value; }

        public bool CreateTask(Task task)
        {
            if (task.Name == "" && task.Description == "") return false;
            File.WriteAllText("tasks.txt", JsonSerializer.Serialize(task));
            return true;
        }
    }
}
