using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class VIN_LIB
    {
    bool CheckVIN(string vin)
        {
            Regex reg = new Regex(@"[A-H,J-N,P,R-Z,\d]{17}");
            if (!reg.IsMatch(vin)) return false;

            return true;
        }
    string GetVINCountry(string vin)
        {
            return null;
        }
    int GetTransportYear(string vin)
        {
            return 0;
        }
    }
}
