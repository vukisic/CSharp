using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public class Item
    {
        public string Description { get; set; }
        public string Status { get; set; }
        public string Revision { get; set; }
        public int PartNumber { get; set; }
        public string Material { get; set; }
        public double Length { get; set; }
        public int Mass { get; set; }
        public string Finish { get; set; }
        public string PruchaseInfo { get; set; }
        public string SupplierName { get; set; }
        public int SupplierCode { get; set; }
        public string Note { get; set; }

        public List<string> WorkCentres { get; set; }

        public Item()
        {

        }

        public override string ToString()
        {
            string output="";
            output += "Description: " + Description + Environment.NewLine;
            output += "Status: " + Status + Environment.NewLine;
            output += "Revision: " + Revision + Environment.NewLine;
            output += "PartNumber: " + PartNumber.ToString() + Environment.NewLine;
            output += "Material: " + Material + Environment.NewLine;
            output += "WorkCentres: " + Environment.NewLine;
            foreach (var item in WorkCentres)
            {
                output += "\t" + item + Environment.NewLine;
            }
            output += "Length: " + Length.ToString() + Environment.NewLine;
            output += "Mass: " + Mass.ToString() + Environment.NewLine;
            output += "Finish: " + Finish + Environment.NewLine;
            output += "PurchaseInfo: " + PruchaseInfo + Environment.NewLine;
            output += "SupplierName: " + SupplierName + Environment.NewLine;
            output += "SupplierCode: " + SupplierCode.ToString() + Environment.NewLine;
            output += "Note: " + Note + Environment.NewLine;

            return output;
                           
        }

    }
}
