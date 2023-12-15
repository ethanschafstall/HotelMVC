using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC
{
    public class Controller
    {
        private Model _model;
        private TaskManager _view;

        public Model Model { get => _model; set => _model = value; }
        public TaskManager View { get => _view; set => _view = value; }

        public void CreateTask(Task task)
        {
            if (_model.CreateTask(task)) 
            {
                _view.DisplaySuccess("Task created");
                _view.ResetInputBoxes();
            }
            else 
            {
                _view.DisplaySuccess("Couldn't create  task");
            }
        }

    }
}
