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
        protected virtual uint Number { get;set; }

        public double korrection;
        public Element parent;
        public HashSet<Element> children;
        public TimeSpan NessaryTime { get; set; }
        
        public string stringFullOfJson;

        private static uint numExit=0;
        private static uint numHall=0;
        private static uint numScenary=0;
        private static uint numFireSection=0;




        public Element(Element elem, HashSet<Element> elChildren):this(elem)
        {
            children = elChildren;
        }
        public Element()
        {
            id = new Guid();

            Type type = ((Object)this).GetType();



//Задание имен элементов по умолчанию.
            if ((this is Hall)) name = "Зальное_помещение" + numHall;
            else if ((this is Exit)) name = "Выход" + numExit;
            else if ((this is FireSection)) name = "Пожарный_отсек" + numFireSection;
            else if ((this is FireSection)) name = "Сценарий" + numScenary;
            else;





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

        bool Rename(string newName)
        {
            name = newName;
            return true;
        }
        public virtual bool Remove() {
            this.parent.children.Remove(this);
            return true; }
        public virtual bool Add(Element elem) {
            this.children.Add(elem);
            elem.parent = this;

            return true; }






    }
}
