using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Calculation
{
    public class Element
    {
        public Guid id;
        public string name;
        public uint number;
        public double korrection;
        public Element parent;
        public HashSet<Element> children;
        public TimeSpan NessaryTime { get; set; }
        
        public string stringFullOfJson;


        public Element(Element elem, HashSet<Element> elChildren):this(elem)
        {
            children = elChildren;
        }
        public Element()
        {
            parent = null;
            children = null;
            //или
            parent = this;
            children.Add(this) ;
        }
        public Element(Element elem ): this()
        {
            parent = elem;
        }


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
