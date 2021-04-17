using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace UnitTestHallTime.Input
{


    class UserRead
    {
        DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(UserRead));
        string fileContent = File.ReadAllText(Directory.GetCurrentDirectory() + "config.json");
        //UserRead jsonn = (UserRead)json.ReadObject(new System.IO.MemoryStream(Encoding.UTF8.GetBytes(fileContent)));

        Dictionary<String, Object> myMap;

        void readAll()
        {

            dynamic data = JObject.Parse(fileContent);
            //1.Наименование сценария(Сценарий#)
            read<string>(data.QscenaryName, data.scenaryName);
            //где "QscenaryName", "scenaryName" - указаны  в json файле
            //2.Метод расчета(Линейная интерполяция)
            read<string>("Наименование сценария", "scenaryName");
            //3.Наименование зального помещения(Зальное_помещение#)

            //4.Объем помещения(1)

            //5.Имеются ли колосники(нет)

            //6.Высота помещения(2.5)
            //7.Метод измерения высоты выходов(от нижней кромки эвакуационного выхода)
            //8.Наименование выхода(Выход#)
            //9.Уровень расположения выхода(0.0)
            //10.Высота до потолка(Высота помещения - Уровень расположения выхода)
            //11.Добавить выход ? (нет)
            //12.Добавить помещение ? (нет)
            //13.Добавить сценраий ? (нет)
            //14.Путь файла отчета. (директория exe файла прогрограмы)
            //15.Формат отчета. (txt, можно попробывать html или rtf)

            

        }


        void read<T>(string welcome, string fieldName)
        {
            Console.WriteLine(welcome);
            object inputData = int.Parse(Console.ReadLine());
            myMap.Add(fieldName, (T) inputData);
        }
    }
}
