﻿using System;
using System.ComponentModel.Composition;
using CarContract;

namespace CarMercedes
{
    [ExportMetadata("Name", "Mercedes")]
    [ExportMetadata("Color", CarColor.Blue)]
    [ExportMetadata("Price", (uint)48000)]
    [Export(typeof(ICarContract))]
    public class Mercedes : ICarContract
    {
        private Mercedes()
        {
            Console.WriteLine("Mercedes constructor.");
        }
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the Mercedes.", name);
        }
    }
}
