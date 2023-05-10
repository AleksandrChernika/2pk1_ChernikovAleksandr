using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Temperature
{
    public event EventHandler<TemperatureEventArgs> TemperatureChanged;
    public void Start()
    {       
        for (int i = -30; i <= 40; i++)
        {
            TemperatureEventArgs args = new TemperatureEventArgs();
            args.Temperature = i;

            OnTemperatureChanged(args);
        }
    }
    protected virtual void OnTemperatureChanged(TemperatureEventArgs e)
    {
        EventHandler<TemperatureEventArgs> handler = TemperatureChanged;
        if (handler != null)
        {
            handler(this, e);
        }
    }
}
