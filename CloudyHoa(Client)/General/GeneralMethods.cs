using Fractions;
using System;
using System.Collections.Generic;
using System.Data;
namespace CloudyHoa_Client_.General
{
    public static class GeneralMethods
    {
        public static bool CheckOwnersShare(DataTable dataTable)
        {
            int numerator; int denominator;
            if (dataTable.Columns["owners_share_numerator"] != null &
                dataTable.Columns["owners_share_denominator"] != null)
            {
                Fraction sum = 0;
                Fraction fraction2;
                foreach (DataRow row in dataTable.Rows)
                {
                    if (bool.Parse(row["owner"].ToString()))
                    {
                        numerator = (int)row["owners_share_numerator"];
                        denominator = (int)row["owners_share_denominator"];
                        fraction2 = new Fraction(numerator, denominator);
                        sum += fraction2;
                    }
                }
                if (sum == 1 || sum == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
