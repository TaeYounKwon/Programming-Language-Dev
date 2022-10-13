using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Fridge : Appliance
    {
        public Fridge(string name) : base(name)
        {
            make = name;
        }
        public override string Description()
        {
            string description = string.Empty;
            description += "I’m a " + make + " fridge.";
            description += Environment.NewLine;
            description += "My state is " + state;
            description += Environment.NewLine;
            return description;
        }

        public override void TurnOff()
        {
            state = ApplianceState.Off;
        }

        public override void TurnOn()
        {
            state = ApplianceState.On;
        }
    }
}
