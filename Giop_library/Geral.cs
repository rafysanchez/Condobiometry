using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;
using Unosquare.WiringPi;

namespace Gpio_library
{
  public  class Geral
    {

        public void Teste(int pino)
        {
            GpioPin gpioPin ;
            

            var pin = Pi.Gpio.Where(x=>x.BcmPin.Equals(pino)).SingleOrDefault();
            pin.PinMode = GpioPinDriveMode.Output;
            pin.Write(true);
        }

        public void SM_28BYJ_48(params int[] pinNumbers)
        {
            ////var gpio = GpioController.GetDefault();

            //IList<GpioPin> pins = new List<GpioPin>();
            //foreach (var pinNumber in pinNumbers)
            //    //pins.Add(gpio.OpenPin(pinNumber));

            ////Pins = pins.ToArray();
            ////Reset();
        }


    }
}
