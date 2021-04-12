using System;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Control
{
    class Saver
    {
        //Сериализация
                    // сохранение данных
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                Person tom = new Person() { Name = "Tom", Age = 35 };
    await JsonSerializer.SerializeAsync<Person>(fs, tom);
    Console.WriteLine("Data has been saved to file");
            }
    }
}
