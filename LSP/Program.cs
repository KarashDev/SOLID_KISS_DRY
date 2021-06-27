using System;

namespace LSP
{
    // Liskov substitution principle / Принцип подстановки Лисков
    class Program
    {
        ////ПЛОХО
        //public class Bird
        //{
        //    private int speed;
        //    private int spacing;
        //    public void Mark(int x, int y) { }

        //    public virtual void Fly()
        //    {
        //        //logic
        //        Console.WriteLine("Птица летит...");
        //    }
        //}

        //public class Kiwi : Bird
        //{
        //    //экземпляр не может исполнить функциональность предка: требуется переопределение
        //    public override void Fly()
        //    {
        //        Console.WriteLine("ОШИБКА: Kiwi не может летать");
        //    }
        //    //требуется создание альтернативного метода
        //    public void Run()
        //    {
        //        Console.WriteLine("Kiwi бежит...");
        //    }
        //}

        //public static void MakeOperation(Bird bird)
        //{
        //    bird.Fly();
        //}

        //ХОРОШО
        public class Bird
        {
            private int speed;
            private int spacing;
            public void Mark(int x, int y) { }

            //решаем проблему бОльшей абстракцией: сразу задаем такой метод, который подойдет
            //для подавляющего большинства наследников
            public virtual void Move()
            {
                //logic
                Console.WriteLine("Птица движется...");
            }
        }

        public class Kiwi : Bird
        {
            public void Run()
            {
                Console.WriteLine("Kiwi бежит...");
            }
            public override void Move()
            {
                this.Run();
            }
        }

        public static void MakeOperation(Bird bird)
        {
            bird.Move();
        }

        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Kiwi kiwi = new Kiwi();

            ////Нарушение принципа: программа перестает работать с другим экземпляром
            //MakeOperation(bird); //Птица летит...
            //MakeOperation(kiwi); //ОШИБКА: Kiwi не может летать

            //MakeOperation(bird); //Птица летит...
            //MakeOperation(kiwi); //ОШИБКА: Kiwi не может летать

            
            ////Принцип соблюден: рограмма работает правильно с любым экземпляром
            //Bird bird = new Bird();
            //Kiwi kiwi = new Kiwi();
            
            //MakeOperation(bird); //Птица движется...
            //MakeOperation(kiwi); //Kiwi бежит...

        }
    }
}
