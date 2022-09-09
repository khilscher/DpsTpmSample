using System;
using Microsoft.Azure.Devices.Provisioning.Security;

namespace DpsTpmSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample based on https://github.com/Azure-Samples/azure-iot-samples-csharp/blob/main/provisioning/Samples/device/TpmSample/Program.cs

            using var security = new SecurityProviderTpmHsm(null);
            Console.WriteLine($"Your EK is {Convert.ToBase64String(security.GetEndorsementKey())}");
        }
    }
}
