using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace NetduinoMUX
{
    public class Program
    {
        private static CD74HC4067 mMux { get; set; }

        /*Here I have Set up the 16-Channel Analog Multiplexer/Demultiplexer CD74HC4067 to expand Rx for COM1 on a Netduino 3 WiFi. Therefore the CD74HC4067
         has it's SIG port connected to D0 on the Netduino*/
        public static void Main()
        {
            //Create your output port Digital Pin variables and set them to false initially
            OutputPort DigitalPin9 = new OutputPort(Pins.GPIO_PIN_D9, false); //Goes to S0
            OutputPort DigitalPin10 = new OutputPort(Pins.GPIO_PIN_D10, false);//Goes to S1
            OutputPort DigitalPin11 = new OutputPort(Pins.GPIO_PIN_D11, false);//Goes to S2
            OutputPort DigitalPin12 = new OutputPort(Pins.GPIO_PIN_D12, false);//Goes to S3

            //Create your MUX object and specify the above digital pins that will be used to configure the board.
            mMux = new CD74HC4067(DigitalPin9, DigitalPin10, DigitalPin11, DigitalPin12);

            //Set the initial Channel that the MUX will be listening on
            mMux.SetPort(MuxChannel.C0);

        }

    }
}
