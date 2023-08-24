using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConCommandDesignPattern.Model
{
    internal class TurnOffLightCommand:ICommand
    {
        private Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
