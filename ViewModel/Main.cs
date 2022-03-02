using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyline.Common.MVVM;
using Skyline.DataMiner.Client.Controls.DataDisplay.Table;
using Skyline.DataMiner.Client.RouterControl.Interfaces;
using Skyline.DataMiner.Client.RouterControl.Model;

namespace RouterControlButtonDesigner.ViewModel
{
    public class Main : ObservableObject
    {
        public MatrixInput Input { get; }
        public MatrixOutput Output { get; }

        public Main()
        {
            Input = new MatrixInput()
            {
                Index = 2,
                Label= "Input 2",
                Description = "Input 2\n(input 2)",
                ConnectionsInfo = "Connected to\n* Output 7 (output 7)\n* Output 8 (output 8)",
                IsConnected = true,
                IsMultiConnected = true
            };
            Input.Model.Values.AddRange(new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });

            Output = new MatrixOutput()
            {
                Index = 7,
                Label = "Output 7",
                Description = "Output 7\n(output 7)",
                ConnectionsInfo = "Connected to Input 2 (input 2)",
                IsConnected = true,
                IsLocked = true
            };
            Output.Model.Values.AddRange(new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
        }
    }
}
