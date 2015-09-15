using System;
using Microsoft.SPOT;

using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;


namespace NetduinoMUX
{
    /*This is a class for using the analog / digital multiplexer (MUX) CD74HC4067*/
    public class CD74HC4067
    {
        private static OutputPort[] DigitalPins { get; set; }

        //Multidimensional Arrays like the below result in an exception: Unsupported multi-dimensional array: 0x1B000001
        private static int[,] MuxChannels = new int[16, 4] {
            {0,0,0,0}, //channel 0
            {1,0,0,0}, //channel 1
            {0,1,0,0}, //channel 2
            {1,1,0,0}, //channel 3
            {0,0,1,0}, //channel 4
            {1,0,1,0}, //channel 5
            {0,1,1,0}, //channel 6
            {1,1,1,0}, //channel 7
            {0,0,0,1}, //channel 8
            {1,0,0,1}, //channel 9
            {0,1,0,1}, //channel 10
            {1,1,0,1}, //channel 11
            {0,0,1,1}, //channel 12
            {1,0,1,1}, //channel 13
            {0,1,1,1}, //channel 14
            {1,1,1,1}  //channel 15
        };

        public CD74HC4067(OutputPort DigitalPinS0, OutputPort DigitalPinS1, OutputPort DigitalPinS2, OutputPort DigitalPinS3)
        {
            DigitalPins = new OutputPort[] { DigitalPinS0, DigitalPinS1, DigitalPinS2, DigitalPinS3 };
        }

        public void SetPort(MuxChannel eMuxChannel)
        {
            //For use with Multidimensional Arrays...
            for (int i = 0; i < 4; i++)
                DigitalPins[i].Write(MuxChannels[(int)eMuxChannel, i] == 0 ? false : true);//any non zero value is true...

        }
    }

    public enum MuxChannel
    {
        C0 = 0,
        C1 = 1,
        C2 = 2,
        C3 = 3,
        C4 = 4,
        C5 = 5,
        C6 = 6,
        C7 = 7,
        C8 = 8,
        C9 = 9,
        C10 = 10,
        C11 = 11,
        C12 = 12,
        C13 = 13,
        C14 = 14,
        C15 = 15
    }

}
