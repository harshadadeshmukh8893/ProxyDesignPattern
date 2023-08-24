using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConCommandDesignPattern.Model
{
    internal class TurnOnLightCommand: ICommand// Concrete command classes
    {
        private Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
