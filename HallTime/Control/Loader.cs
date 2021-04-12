using HallTime.Calculation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



namespace HallTime.Control
{
    class Loader
    {
        //Десериализация
async void loadAsync (){ 
     using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                Element element;
                Element restoredPerson = await JsonSerializer.DeserializeAsync<Element>(fs);
    Console.WriteLine($"Name: {restoredPerson.Name}  Age: {restoredPerson.Age}");
            
        }
}
}

