using System;
using System.Collections.Generic;

namespace Loginadmin.Class
{
    // Class to map the main Firebase data structure
    public class SensorReading
    {
        public Email email { get; set; }  // Email of the user
        public HeartRate heartRate { get; set; }  // Heart rate data
        public Oximeter oximeter { get; set; }  // Oximeter data
    }

    // Subclass to map Email data (if it's nested)
    public class Email
    {
        public string Value { get; set; }  // Email value (nested in Firebase)
    }

    // Subclass to map Heart Rate data
    public class HeartRate
    {
        public int value { get; set; }  // Heart rate value
    }

    // Subclass to map Oximeter data
    public class Oximeter
    {
        public int value { get; set; }  // Oxygen level (SpO2) value
    }

    // Simplified class for DataGridView display
    public class VitalReading
    {
        public string Email { get; set; }  // User email
        public int HeartRate { get; set; }  // Heart rate value
        public int Oximeter { get; set; }  // Oximeter value
    }
}
