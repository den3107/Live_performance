using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatRental.Types;

namespace BoatRental
{
    class ExportController
    {
        public static void ExportTextFile(HireContract contract)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = dialog.FileName;
                if (!filename.EndsWith(".txt") && !filename.EndsWith(".text"))
                {
                    filename += ".txt";
                }
                using (Stream stream = dialog.OpenFile())
                using (StreamWriter file = new StreamWriter(stream))
                {
                    file.WriteLine("Eigenaar: " + contract.HirerEmailaddress);
                    file.WriteLine("--------------------");
                    file.WriteLine("Algemene informatie:");
                    file.WriteLine("\tContract start datum: " + contract.DateStart.ToString("yyyy/MM/dd"));
                    file.WriteLine("\tContract eind datum: " + contract.DateEnd.ToString("yyyy/MM/dd"));
                    file.WriteLine("\tAantal friese meren om te bevaring: " + contract.FrieschLakes);
                    file.WriteLine("--------------------");
                    file.WriteLine();
                    file.WriteLine("--------------------");
                    if (contract.Lakes.Count > 0)
                    {
                        file.WriteLine("Bevaren speciale meren:");
                        foreach (Lake lake in contract.Lakes)
                        {
                            file.WriteLine("\t" + lake.Name + "[€" + lake.Price + "]");
                        }
                        file.WriteLine("--------------------");
                        file.WriteLine();
                        file.WriteLine("--------------------");
                    }
                    file.Write("Informatie gebruikte boten:");
                    foreach (Boat boat in contract.Boats)
                    {
                        file.WriteLine();
                        file.WriteLine("\tNaam en prijs boot: " + boat.Name + "[€" + boat.Motor.Price + "]");
                        file.WriteLine("\tBoot type: " + boat.Kind.Name + " [" + boat.Kind.Type + "]");
                        file.WriteLine("\tBoot motor: " + boat.Motor.Name + " [" + boat.Motor.TankCapacity + "L]");
                        if (boat.Motor.MayTraverseLakes)
                        {
                            file.WriteLine("\tDeze boot mag op speciale meren varen.");
                        }
                        if (!boat.Kind.PaysForLock)
                        {
                            file.WriteLine("\tDeze boot hoeft niet te betalen voor sluisen.");
                        }
                        file.Write("-----");
                    }
                    file.WriteLine("---------------");
                    if (contract.Items.Count > 0)
                    {
                        file.WriteLine();
                        file.WriteLine("--------------------");
                        file.WriteLine("Bijgekochten artikelen:");
                        foreach (Item item in contract.Items)
                        {
                            file.WriteLine("\t" + item.Name + " [€" + item.Price + "]");
                        }
                        file.WriteLine("--------------------");
                    }
                }
            }
        }
    }
}
