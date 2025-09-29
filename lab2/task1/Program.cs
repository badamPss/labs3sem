using System;

namespace lab2.Task1
{
    class Program
    {
        static void Main()
        {
            var classRoom = new ClassRoom(
                new ExcelentPupil("Аня"),
                new GoodPupil("Борис"),
                new BadPupil("Вика")
            );

            classRoom.ShowAll();
        }
    }
}