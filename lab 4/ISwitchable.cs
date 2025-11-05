using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseSystem
{
    public interface ISwitchable
    {
        bool IsOn { get; }

        public void TurnOn();
        public void TurnOff();
    }

}

