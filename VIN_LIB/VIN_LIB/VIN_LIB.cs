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

        string CheckCoun(string vin)
        {
            Enum slovar = new Enum();
            string strana;
            string alfavit = "ABCDEFGHJKLMNPRSTUVWXYZ1234567890";
            for (int i = 0; i < slovar.coun.Count; i++)
            {
                if (slovar.coun.ElementAt(i).Key[0].ToString() == vin[0].ToString() || slovar.coun.ElementAt(i).Key[3].ToString() == vin[0].ToString())
                {
                     if((alfavit.Substring(alfavit.IndexOf(slovar.coun.ElementAt(i).Key[1]), 1+alfavit.IndexOf(slovar.coun.ElementAt(i).Key[4]) - alfavit.IndexOf(slovar.coun.ElementAt(i).Key[1]))).Contains(vin[1]))
                    {
                        return slovar.coun.ElementAt(i).Value;
                    }

                }
            }
            return null;

        }
    }
}
