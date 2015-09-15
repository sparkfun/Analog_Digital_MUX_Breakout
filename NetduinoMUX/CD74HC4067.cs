using System;
using Microsoft.SPOT;

using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;


namespace NetduinoMUX
{
    /*This is a class for using the analog / digital multiplexer (MUX) CD74HC4067*/
    /*This is a class for using the analog / digital multiplexer (MUX) CD74HC4067*/
    public class CD74HC4067
    {
        private static OutputPort[] DigitalPins { get; set; }

        public CD74HC4067(OutputPort DigitalPinS0, OutputPort DigitalPinS1, OutputPort DigitalPinS2, OutputPort DigitalPinS3)
        {
            DigitalPins = new OutputPort[] { DigitalPinS0, DigitalPinS1, DigitalPinS2, DigitalPinS3 };
        }

        public void SetPort(MuxChannel eMuxChannel)
        {

            switch (eMuxChannel)
            {
                case MuxChannel.C0:
                    for (int intCounter = 0; intCounter < 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C0[intCounter] == '0' ? false : true); //any non zero value is true...
                    break;
                case MuxChannel.C1:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C1[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C2:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C2[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C3:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C3[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C4:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C4[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C5:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C5[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C6:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C6[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C7:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C7[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C8:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C8[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C9:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C9[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C10:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C10[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C11:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C11[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C12:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C12[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C13:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C13[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C14:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C14[intCounter] == '0' ? false : true);
                    break;
                case MuxChannel.C15:
                    for (int intCounter = 0; intCounter <= 4; intCounter++)
                        DigitalPins[intCounter].Write(MUXPorts.C15[intCounter] == '0' ? false : true);
                    break;
            }

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

    static class MUXPorts
    {
        public static string C0 { get { return "0000"; } }
        public static string C1 { get { return "1000"; } }
        public static string C2 { get { return "0100"; } }
        public static string C3 { get { return "1100"; } }
        public static string C4 { get { return "0010"; } }
        public static string C5 { get { return "1010"; } }
        public static string C6 { get { return "0110"; } }
        public static string C7 { get { return "1110"; } }
        public static string C8 { get { return "0001"; } }
        public static string C9 { get { return "1001"; } }
        public static string C10 { get { return "0101"; } }
        public static string C11 { get { return "1101"; } }
        public static string C12 { get { return "0011"; } }
        public static string C13 { get { return "1011"; } }
        public static string C14 { get { return "0111"; } }
        public static string C15 { get { return "1111"; } }
    }

}
