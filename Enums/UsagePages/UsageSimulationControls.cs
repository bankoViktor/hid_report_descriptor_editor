using HID_Report_Descriptor_Editor.Attributes;
using System.ComponentModel;

namespace HID_Report_Descriptor_Editor.Enums.UsagePages
{
    public enum UsageSimulationControls : ushort
    {
        // ширина 2 байта
        [Description("Undefined")]
        Undefined = 0x0000,

        [Description("Flight Simulation Device")]
        [UsageType("CA")]
        FlightSimulationDevice = 0x0001,

        [Description("Automobile Simulation Device")]
        [UsageType("CA")]
        AutomobileSimulationDevice = 0x0002,

        [Description("Tank Simulation Device")]
        [UsageType("CA")]
        TankSimulationDevice = 0x0003,

        [Description("Spaceship Simulation Device")]
        [UsageType("CA")]
        SpaceshipSimulationDevice = 0x0004,

        [Description("Submarine Simulation Device")]
        [UsageType("CA")]
        SubmarineSimulationDevice = 0x0005,

        [Description("Sailing Simulation Device")]
        [UsageType("CA")]
        SailingSimulationDevice = 0x0006,

        [Description("Motorcycle Simulation Device")]
        [UsageType("CA")]
        MotorcycleSimulationDevice = 0x0007,

        [Description("Sports Simulation Device")]
        [UsageType("CA")]
        SportsSimulationDevice = 0x0008,

        [Description("Airplane Simulation Device")]
        [UsageType("CA")]
        AirplaneSimulationDevice = 0x0009,

        [Description("Helicopter Simulation Device")]
        [UsageType("CA")]
        HelicopterSimulationDevice = 0x000A,

        [Description("Magic Carpet Simulation Device")]
        [UsageType("CA")]
        MagicCarpetSimulationDevice = 0x000B,

        [Description("Bicycle Simulation Device")]
        [UsageType("CA")]
        BicycleSimulationDevice = 0x000C,

        // reserved 0x000D - 0x001F

        [Description("Flight Control Stick")]
        [UsageType("DV")]
        FlightControlStick = 0x0020,

        [Description("Flight Stick")]
        [UsageType("DV")]
        FlightStick = 0x0021,

        [Description("Cyclic Control")]
        [UsageType("CP")]
        CyclicControl = 0x0022,

        [Description("Cyclic Trim")]
        [UsageType("CP")]
        CyclicTrim = 0x0023,

        [Description("Flight Yoke")]
        [UsageType("CA")]
        FlightYoke = 0x0024,

        [Description("Track Control")]
        [UsageType("CP")]
        TrackControl = 0x0025,

        // reserved 0x0026 - 0x00AF

        [Description("Aileron")]
        [UsageType("DV")]
        Aileron = 0x00B0,

        [Description("Aileron Trim")]
        [UsageType("DV")]
        AileronTrim = 0x00B1,

        [Description("Anti-Torque Control")]
        [UsageType("DV")]
        Anti_TorqueControl = 0x00B2,

        [Description("Autopilot Enable")]
        [UsageType("OOC")]
        AutopilotEnable = 0x00B3,

        [Description("Chaff Release")]
        [UsageType("OSC")]
        ChaffRelease = 0x00B4,

        [Description("Collective Control")]
        [UsageType("DV")]
        CollectiveControl = 0x00B5,

        [Description("Dive Brake")]
        [UsageType("DV")]
        DiveBrake = 0x00B6,

        [Description("Electronic Countermeasures")]
        [UsageType("OOC")]
        ElectronicCountermeasures = 0x00B7,

        [Description("Elevator")]
        [UsageType("DV")]
        Elevator = 0x00B8,

        [Description("Elevator Trim")]
        [UsageType("DV")]
        ElevatorTrim = 0x00B9,

        [Description("Rudder")]
        [UsageType("DV")]
        Rudder = 0x00BA,

        [Description("Throttle")]
        [UsageType("DV")]
        Throttle = 0x00BB,

        [Description("Flight Communications")]
        [UsageType("OOC")]
        FlightCommunications = 0x00BC,

        // TODO дописать Usage Simulation Controls Page

        // reserved 0x00D1 - 0xFFFF
    }
}
