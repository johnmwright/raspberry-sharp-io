namespace Raspberry.IO.GeneralPurpose
{
    /// <summary>
    /// Represents a connector pin.
    /// </summary>
    public enum ConnectorPin
    {
        /// <summary>
        /// Connector P1, pin 3.
        /// </summary>
        P1Pin3,

        /// <summary>
        /// Connector P1, pin 3.
        /// </summary>
        P1Pin03 = P1Pin3,

        /// <summary>
        /// Connector P1, pin 5.
        /// </summary>
        P1Pin5,

        /// <summary>
        /// Connector P1, pin 5.
        /// </summary>
        P1Pin05 = P1Pin5,

        /// <summary>
        /// Connector P1, pin 7.
        /// </summary>
        P1Pin7,

        /// <summary>
        /// Connector P1, pin 7.
        /// </summary>
        P1Pin07 = P1Pin7,

        /// <summary>
        /// Connector P1, pin 8.
        /// </summary>
        P1Pin8,

        /// <summary>
        /// Connector P1, pin 8.
        /// </summary>
        P1Pin08 = P1Pin8,

        /// <summary>
        /// Connector P1, pin 10.
        /// </summary>
        P1Pin10,

        /// <summary>
        /// Connector P1, pin 11.
        /// </summary>
        P1Pin11,

        /// <summary>
        /// Connector P1, pin 12.
        /// </summary>
        P1Pin12,

        /// <summary>
        /// Connector P1, pin 13.
        /// </summary>
        P1Pin13,

        /// <summary>
        /// Connector P1, pin 15.
        /// </summary>
        P1Pin15,

        /// <summary>
        /// Connector P1, pin 16.
        /// </summary>
        P1Pin16,

        /// <summary>
        /// Connector P1, pin 18.
        /// </summary>
        P1Pin18,

        /// <summary>
        /// Connector P1, pin 19.
        /// </summary>
        P1Pin19,

        /// <summary>
        /// Connector P1, pin 21.
        /// </summary>
        P1Pin21,

        /// <summary>
        /// Connector P1, pin 22.
        /// </summary>
        P1Pin22,

        /// <summary>
        /// Connector P1, pin 23.
        /// </summary>
        P1Pin23,

        /// <summary>
        /// Connector P1, pin 24.
        /// </summary>
        P1Pin24,

        /// <summary>
        /// Connector P1, pin 26.
        /// </summary>
        P1Pin26,


        // Pins 27+ exist starting from Model B+

        /// <summary>
        /// Connector P1, pin 27.
        /// </summary>
        P1Pin27,

        /// <summary>
        /// Connector P1, pin 28.
        /// </summary>
        P1Pin28,

        /// <summary>
        /// Connector P1, pin 29.
        /// </summary>
        P1Pin29,

        /// <summary>
        /// Connector P1, pin 31.
        /// </summary>
        P1Pin31,

        /// <summary>
        /// Connector P1, pin 32.
        /// </summary>
        P1Pin32,

        /// <summary>
        /// Connector P1, pin 33.
        /// </summary>
        P1Pin33,

        /// <summary>
        /// Connector P1, pin 35.
        /// </summary>
        P1Pin35,

        /// <summary>
        /// Connector P1, pin 36.
        /// </summary>
        P1Pin36,

        /// <summary>
        /// Connector P1, pin 37.
        /// </summary>
        P1Pin37,

        /// <summary>
        /// Connector P1, pin 38.
        /// </summary>
        P1Pin38,

        /// <summary>
        /// Connector P1, pin 40.
        /// </summary>
        P1Pin40,


        // P5 Connector exist on Rev2 boards (no longer on B+)

        /// <summary>
        /// Connector P5, pin 3.
        /// </summary>
        P5Pin3,

        /// <summary>
        /// Connector P5, pin 3.
        /// </summary>
        P5Pin03 = P5Pin3,

        /// <summary>
        /// Connector P5, pin 4.
        /// </summary>
        P5Pin4,

        /// <summary>
        /// Connector P5, pin 4.
        /// </summary>
        P5Pin04 = P5Pin4,

        /// <summary>
        /// Connector P5, pin 5.
        /// </summary>
        P5Pin5,

        /// <summary>
        /// Connector P5, pin 5.
        /// </summary>
        P5Pin05 = P5Pin5,

        /// <summary>
        /// Connector P5, pin 6.
        /// </summary>
        P5Pin6,

        /// <summary>
        /// Connector P5, pin 6.
        /// </summary>
        P5Pin06 = P5Pin6,



        /// <summary>
        /// BCM Pin 2
        /// </summary>
        GPIO2 = P1Pin03,


        /// <summary>
        /// BCM Pin 2
        /// </summary>
        GPIO02 = GPIO2,


        /// <summary>
        /// BCM Pin 3
        /// </summary>
        GPIO3 = P1Pin05,

        /// <summary>
        /// BCM Pin 3
        /// </summary>
        GPIO03 = GPIO3,


        /// <summary>
        /// BCM Pin 4
        /// </summary>
        GPIO4 = P1Pin07,

        /// <summary>
        /// BCM Pin 4
        /// </summary>
        GPIO04 = GPIO4,


        /// <summary>
        /// BCM Pin 5
        /// </summary>
        GPIO5 = P1Pin29,

        /// <summary>
        /// BCM Pin 5
        /// </summary>
        GPIO05 = GPIO5,


        /// <summary>
        /// BCM Pin 6
        /// </summary>
        GPIO6 = P1Pin31,

        /// <summary>
        /// BCM Pin 6
        /// </summary>
        GPIO06 = GPIO6,


        /// <summary>
        /// BCM Pin 7
        /// </summary>
        GPIO7 = P1Pin24,

        /// <summary>
        /// BCM Pin 7
        /// </summary>
        GPIO07 = GPIO7,


        /// <summary>
        /// BCM Pin 8
        /// </summary>
        GPIO8 = P1Pin26,

        /// <summary>
        /// BCM Pin 8
        /// </summary>
        GPIO08 = GPIO8,


        /// <summary>
        /// BCM Pin 9
        /// </summary>
        GPIO9 = P1Pin21,


        /// <summary>
        /// BCM Pin 9
        /// </summary>
        GPIO09 = GPIO9,


        /// <summary>
        /// BCM Pin 10
        /// </summary>
        GPIO10 = P1Pin19,


        /// <summary>
        /// BCM Pin 11
        /// </summary>
        GPIO11 = P1Pin23,


        /// <summary>
        /// BCM Pin 12
        /// </summary>
        GPIO12 = P1Pin32,

        /// <summary>
        /// BCM Pin 13
        /// </summary>
        GPIO13 = P1Pin33,

        /// <summary>
        /// BCM Pin 14
        /// </summary>
        GPIO14 = P1Pin8,

        /// <summary>
        /// BCM Pin 15
        /// </summary>
        GPIO15 = P1Pin10,

        /// <summary>
        /// BCM Pin 16
        /// </summary>
        GPIO16 = P1Pin36,

        /// <summary>
        /// BCM Pin 17
        /// </summary>
        GPIO17 = P1Pin11,

        /// <summary>
        /// BCM Pin 18
        /// </summary>
        GPIO18 = P1Pin12,

        /// <summary>
        /// BCM Pin 19
        /// </summary>
        GPIO19 = P1Pin35,

        /// <summary>
        /// BCM Pin 20
        /// </summary>
        GPIO20 = P1Pin38,

        /// <summary>
        /// BCM Pin 21
        /// </summary>
        GPIO21 = P1Pin40,

        /// <summary>
        /// BCM Pin 22
        /// </summary>
        GPIO22 = P1Pin15,

        /// <summary>
        /// BCM Pin 23
        /// </summary>
        GPIO23 = P1Pin16,

        /// <summary>
        /// BCM Pin 24
        /// </summary>
        GPIO24 = P1Pin18,

        /// <summary>
        /// BCM Pin 25
        /// </summary>
        GPIO25 = P1Pin22,

        /// <summary>
        /// BCM Pin 26
        /// </summary>
        GPIO26 = P1Pin37,

        /// <summary>
        /// BCM Pin 27
        /// </summary>
        GPIO27 = P1Pin13,

    }
}