using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC
{
    public class Model
    {
        private Controller _controller;

        public Controller Controller { get => _controller; set => _controller = value; }
    }
}
