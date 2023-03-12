using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> processorType = new Dictionary<string, string>(){
            {"1", "Other"},
            {"2", "Unknown"},
            {"3", "Central Processor"},
            {"4", "Math Processor"},
            {"5", "DSP Processor"},
            {"6", "Video Processor"}
        };

        Dictionary<string, string> arhitecture = new Dictionary<string, string>(){
            {"0", "x86"},
            {"1", "MIPS"},
            {"2", "Alpha"},
            {"3", "PowerPC"},
            {"5", "ARM"},
            {"6", "ia64"},
            {"9", "x64"}
        };

        Dictionary<string, string> processorFamily = new Dictionary<string, string>(){
            {"1", "Other"},
            {"2", "Unknown"},
            {"3", "8086"},
            {"198", "Intel(R) Core(TM) i7 processor"},
            {"205", "Intel(R) Core(TM) i5 processor"},
            {"207", "Intel(R) Core(TM) i9 processor"},
            {"206", "Intel(R) Core(TM) i3 processor"},
            {"182", "AMD Athlon(TM) XP Family"},
            {"131", "AMD Athlon(TM) 64 Processor Family"}
        };

        Dictionary<string, string> availability = new Dictionary<string, string>(){
            {"1", "Other"},
            {"2", "Unknown"},
            {"3", "Running/Full Power"},
            {"4", "Warning"},
            {"5", "In Test"},
            {"7", "Power Off"},
            {"8", "Off Line"},
            {"9", "Off Duty"},
            {"10", "Degraded"},
            {"13", "Power Save - Unknown"},
            {"14", "Power Save - Low Power Mode"},
            {"15", "Power Save - Standby"}
        };

        Dictionary<string, string> cacheLevel = new Dictionary<string, string>(){
            {"1", "Other"},
            {"2", "Unknown"},
            {"3", "Primary"},
            {"4", "Secondary"},
            {"5", "Tertiary"},
            {"6", "Not Applicable"}
        };

        Dictionary<string, string> cacheLocation = new Dictionary<string, string>(){
            {"0", "Internal"},
            {"1", "External"},
            {"2", "Reserved"},
            {"3", "Unknown"}
        };

        Dictionary<string, string> cacheAccess = new Dictionary<string, string>(){
            {"0", "Unknown"},
            {"1", "Readable"},
            {"2", "Writeable"},
            {"3", "Read/Write Supported"},
            {"4", "Write Once"}
        };

        Dictionary<string, string> cacheType = new Dictionary<string, string>(){
            {"1", "Other"},
            {"2", "Unknown"},
            {"3", "Instruction"},
            {"4", "Data"},
            {"5", "Unified"}
        };

        Dictionary<string, string> cacheWritePolicy = new Dictionary<string, string>(){
            {"1", "Other"},
            {"2", "Unknown"},
            {"3", "Write Back"},
            {"4", "Write Through"},
            {"5", "Tertialy"},
            {"6", "Not Applicable"}
        };

        Dictionary<string, string> cacheAssociativity = new Dictionary<string, string>(){
            {"1", "Other"},
            {"2", "Unknown"},
            {"3", "Direct Mapped"},
            {"4", "2-way Set-Associative"},
            {"5", "4-way Set-Associative"},
            {"6", "Full Associative"},
            {"7", "8-way Set-Associative"},
            {"8", "16-way Set-Associative"},
            {"9", "Error"}
        };

        Dictionary<string, string> memoryType = new Dictionary<string, string>()
        {
            {"0", "Unknown"},
            {"1", "Other"},
            {"2", "DRAM"},
            {"3", "Synchronous DRAM"},
            {"4", "Cache DRAM"},
            {"7", "VRAM"},
            {"8", "SRAM"},
            {"9", "RAM"},
            {"10", "ROM"},
            {"12", "EEPROM"},
            {"13", "FEPROM"},
            {"17", "SDRAM"},
            {"18", "SGRAM"},
            {"20", "DDR"},
            {"21", "DDR2"},
            {"26", "DDR4"},
        };

        public Form1()
        {
            InitializeComponent();
            getProcessorDetails();
            getCacheDetails();
            getRAMDetails();
        }

        private void getProcessorDetails()
        {
            var processor = new ManagementObjectSearcher("select * from Win32_Processor");
            var processorString = new StringBuilder();

            foreach (ManagementObject obj in processor.Get())
            {
                processorString.AppendLine("*CPU*");
                processorString.AppendLine("Processor details:");
                processorString.AppendLine("");
                processorString.AppendLine("Name: " + obj["Name"]);
                processorString.AppendLine("Type: " + processorType[obj["ProcessorType"].ToString()]);
                processorString.AppendLine("Manufacturer: " + obj["Manufacturer"]);
                processorString.AppendLine("Caption: " + obj["Caption"]);
                processorString.AppendLine("Family: " + processorFamily[obj["Family"].ToString()]);
                processorString.AppendLine("DeviceID: " + obj["DeviceID"]);
                processorString.AppendLine("Architecture: " + arhitecture[obj["Architecture"].ToString()]);
                processorString.AppendLine("Address Width: " + obj["AddressWidth"] + " bits");
                processorString.AppendLine("Data Width: " + obj["DataWidth"] + " bits");
                processorString.AppendLine("Max Clock Speed: " + obj["MaxClockSpeed"] + " MHz");
                processorString.AppendLine("Current Clock Speed: " + obj["CurrentClockSpeed"] + " MHz");
                processorString.AppendLine("Thread Count: " + obj["ThreadCount"]);
                processorString.AppendLine("Current Voltage: " + obj["CurrentVoltage"]);
                processorString.AppendLine("Number Of Cores: " + obj["NumberOfCores"]);
                processorString.AppendLine("Number Of Logical Processors: " + obj["NumberOfLogicalProcessors"]);
                processorString.AppendLine("L2 Cache Size: " + obj["L2CacheSize"] + " KB");
                processorString.AppendLine("L3 Cache Size: " + obj["L3CacheSize"] + " KB");
                processorString.AppendLine("Load Percentage: " + obj["LoadPercentage"]);
                processorString.AppendLine("Virtualization Firmware Enabled: " + obj["VirtualizationFirmwareEnabled"]);
                processorString.AppendLine("Availability: " + availability[obj["Availability"].ToString()]);
                processorString.AppendLine("");
            }
            this.textBox1.AppendText(processorString.ToString());
        }

        private void getCacheDetails()
        {
            var cacheMemory = new ManagementObjectSearcher("select * from Win32_CacheMemory");
            var cacheString = new StringBuilder();

            cacheString.AppendLine("");
            cacheString.AppendLine("*CACHE MEMORY*");

            foreach (ManagementObject obj in cacheMemory.Get())
            {
                cacheString.AppendLine("");
                cacheString.AppendLine(" -> " + cacheLevel[obj["Level"].ToString()] + " Cache Memory Details:");
                cacheString.AppendLine("");
                cacheString.AppendLine("Name: " + obj["Name"]);
                cacheString.AppendLine("Level: " + cacheLevel[obj["Level"].ToString()]);
                cacheString.AppendLine("Location: " + cacheLocation[obj["Location"].ToString()]);
                cacheString.AppendLine("Caption: " + obj["Caption"]);
                cacheString.AppendLine("Purpose: " + obj["Purpose"]);
                cacheString.AppendLine("Block Size: " + obj["BlockSize"] + " bytes");
                cacheString.AppendLine("Installed Size: " + obj["InstalledSize"] + " KB");
                cacheString.AppendLine("Max Cache Size: " + obj["MaxCacheSize"] + " KB");
                cacheString.AppendLine("Cache Type: " + cacheType[obj["CacheType"].ToString()]);
                cacheString.AppendLine("Write Policy: " + cacheWritePolicy[obj["WritePolicy"].ToString()]);
                cacheString.AppendLine("Associativity: " + cacheAssociativity[obj["Associativity"].ToString()]);
            }
            this.textBox1.AppendText(cacheString.ToString());
        }

        private void getRAMDetails()
        {
            var ramMemory = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
            var ramString = new StringBuilder();

            ramString.AppendLine("");
            ramString.AppendLine("*RAM MEMORY*");

            foreach(ManagementObject obj in ramMemory.Get())
            {
                ramString.AppendLine("");
                ramString.AppendLine(" -> " + obj["Tag"] + " Details");
                ramString.AppendLine("");
                ramString.AppendLine("Name: " + obj["Name"]);
                ramString.AppendLine("Manufacturer: " + obj["Manufacturer"]);
                ramString.AppendLine("SerialNumber: " + obj["SerialNumber"]);
                //ramString.AppendLine("Memory Type: " + memoryType[obj["MemoryType"].ToString()]);
                ramString.AppendLine("Capacity: " + Convert.ToDouble(obj["Capacity"]) / (1024f * 1024f * 1024f) + " GB");
                ramString.AppendLine("Speed: " + obj["Speed"] + "ns");
                ramString.AppendLine("DataWidth: " + obj["DataWidth"] + " bits");
                ramString.AppendLine("Configured Clock Speed: " + obj["ConfiguredClockSpeed"] + " MHz");
                ramString.AppendLine("Configured Voltage: " + obj["ConfiguredVoltage"] + " mV");
                ramString.AppendLine("Device Locator: " + obj["DeviceLocator"]);
            }
            this.textBox1.AppendText(ramString.ToString());
        }

        private void diskBtn_Click(object sender, EventArgs e)
        {
            FormDisk fd = new FormDisk();
            fd.Visible = true;
        }

        private void cpuBtn_Click(object sender, EventArgs e)
        {
            FormInstruction fi = new FormInstruction();
            fi.Visible = true;
        }
    }
}
