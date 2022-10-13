using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Dishwasher : Appliance
    {
        public Dishwasher (string make) : base(make)
        {
            this.make = make;
        }
        public override string Description()
        {
            string description = string.Empty;
            description += "I’m a " + make + " dishwasher.";
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
