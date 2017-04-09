using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMagneticalAnalyse
{
    public class ExecuteService
    {
        public void startToAnaliysys(int measuredFrequency, double lenghtOfAntenna, int maxDistance)
        {
            //волновое сопротивление свободного пространства
            int h = 377;
            double value_1 = (h * lenghtOfAntenna) / (2* Math.PI);

            for (int i = 1; i < maxDistance; i++)
            {

            }
      
        }
    }
}
