using System.Data;

namespace Revision1 {
    public sealed class LegacyDevice {

        public bool IsConnected { get; private set; } = false;
        public bool IsCharging { get; private set; } = false;


    public void EstablishConnection() {
        Console.WriteLine($"{nameof(LegacyDevice)} connected.");
        this.IsConnected = true;
    }

    public void LegacyRecharge() {
        Console.WriteLine($"{nameof(LegacyDevice)} charging.");
        this.IsCharging = true;
    }

    }
}