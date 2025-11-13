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

        //Jagged Arrays like the below, however, are supported...
        private static int[][] MuxChannels = new int[][] {
            new int[] {0,0,0,0}, //channel 0
            new int[] {1,0,0,0}, //channel 1
            new int[] {0,1,0,0}, //channel 2
            new int[] {1,1,0,0}, //channel 3
            new int[] {0,0,1,0}, //channel 4
            new int[] {1,0,1,0}, //channel 5
            new int[] {0,1,1,0}, //channel 6
            new int[] {1,1,1,0}, //channel 7
            new int[] {0,0,0,1}, //channel 8
            new int[] {1,0,0,1}, //channel 9
            new int[] {0,1,0,1}, //channel 10
            new int[] {1,1,0,1}, //channel 11
            new int[] {0,0,1,1}, //channel 12
            new int[] {1,0,1,1}, //channel 13
            new int[] {0,1,1,1}, //channel 14
            new int[] {1,1,1,1}  //channel 15
        };


        public CD74HC4067(OutputPort DigitalPinS0, OutputPort DigitalPinS1, OutputPort DigitalPinS2, OutputPort DigitalPinS3)
        {
            DigitalPins = new OutputPort[] { DigitalPinS0, DigitalPinS1, DigitalPinS2, DigitalPinS3 };
        }

        public void SetPort(MuxChannel eMuxChannel)
        {
            //For use with Jagged Arrays...
            for (int i = 0; i < 4; i++)
                DigitalPins[i].Write(MuxChannels[(int)eMuxChannel][i] == 0 ? false : true);//any non zero value is true...
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
