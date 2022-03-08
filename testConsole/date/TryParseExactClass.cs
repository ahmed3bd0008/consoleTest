using System;
using System.Globalization;

namespace DateTest
{
    public  class TryParseExactClass
    {
        CultureInfo cultureInfo = new CultureInfo("en-US");
        public  DateTime getDate(string dateStr){
            DateTime dateTime;
            if(!DateTime.TryParseExact(dateStr,"dd/mm/yyyy", cultureInfo, System.Globalization.DateTimeStyles.AssumeLocal,out dateTime))
                        dateTime=DateTime.Now;
            return dateTime;
        }
    }
}