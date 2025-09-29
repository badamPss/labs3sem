using System;

namespace lab2
{
    public class Pupil
    {
        public string Name { get; }

        public Pupil(string name) => Name = name;

        public virtual void Study()  => Console.WriteLine($"{Name}: учится обычно.");
        public virtual void Read()   => Console.WriteLine($"{Name}: читает обычно.");
        public virtual void Write()  => Console.WriteLine($"{Name}: пишет обычно.");
        public virtual void Relax()  => Console.WriteLine($"{Name}: отдыхает обычно.");
    }

    public sealed class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name) { }
        public override void Study()  => Console.WriteLine($"{Name}: учится отлично!");
        public override void Read()   => Console.WriteLine($"{Name}: читает быстро и вдумчиво.");
        public override void Write()  => Console.WriteLine($"{Name}: пишет без ошибок.");
        public override void Relax()  => Console.WriteLine($"{Name}: отдыхает с пользой.");
    }

    public sealed class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name) { }
        public override void Study()  => Console.WriteLine($"{Name}: учится хорошо.");
        public override void Read()   => Console.WriteLine($"{Name}: читает хорошо.");
        public override void Write()  => Console.WriteLine($"{Name}: пишет аккуратно.");
        public override void Relax()  => Console.WriteLine($"{Name}: отдыхает умеренно.");
    }

    public sealed class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name) { }
        public override void Study()  => Console.WriteLine($"{Name}: почти не учится…");
        public override void Read()   => Console.WriteLine($"{Name}: читает нехотя.");
        public override void Write()  => Console.WriteLine($"{Name}: пишет с ошибками.");
        public override void Relax()  => Console.WriteLine($"{Name}: отдыхает постоянно :)");
    }
}