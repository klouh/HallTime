using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Calculation
{
    public class Element
    {
        protected Guid id;
        protected string name;
        protected uint number;
        protected double korrection;
        protected TimeSpan NessaryTime { get;set};
        
        protected string stringFullOfJson;

        void fn()
        {
            //stringFullOfJson - имя класса
            JToken token = JObject.Parse(stringFullOfJson);
            
            // наименование класса или поля
            
            int page = (int)token.SelectToken("page");
            int totalPages = (int)token.SelectToken("total_pages");
        }

    }
}
