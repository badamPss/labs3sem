using System;

namespace lab2
{
    public class ClassRoom
    {
        private readonly Pupil[] _pupils = new Pupil[4];
        
        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils == null || pupils.Length < 2 || pupils.Length > 4)
                throw new ArgumentException("ClassRoom принимает 2–4 учеников.");

            for (int i = 0; i < 4; i++)
            {
                _pupils[i] = i < pupils.Length
                    ? pupils[i]
                    : new GoodPupil($"Ученик_{i+1}");
            }
        }

        public void ShowAll()
        {
            Console.WriteLine("=== Как учатся ===");
            foreach (var p in _pupils) p.Study();

            Console.WriteLine("\n=== Как читают ===");
            foreach (var p in _pupils) p.Read();

            Console.WriteLine("\n=== Как пишут ===");
            foreach (var p in _pupils) p.Write();

            Console.WriteLine("\n=== Как отдыхают ===");
            foreach (var p in _pupils) p.Relax();
        }
    }
}