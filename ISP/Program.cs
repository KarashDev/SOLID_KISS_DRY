using System;

namespace ISP
{
    //Interface segregation principle / Принцип разделения интерфейсов
    class Program
    {

        //ПЛОХО
        interface IAnimal
        {
            void Fly();
            void Walk();
        }
        class Animal
        {
            public string Species { get; set; }
            public int LegsCount { get; set; }
        }
       
        class Bird : Animal, IAnimal
        {
            //Здесь все хорошо
            public void Fly()
            {
                //logic
            }
            public void Walk()
            {
                //logic
            }
        }

        class Dog : Animal, IAnimal
        {
            //"заглушка" - собака не реализует метод интерфейса, принцип ISP нарушен
            public void Fly()
            {
                throw new NotImplementedException();
            }

            public void Walk()
            {
                //logic
            }
        }
        //Помимо проблемы неиспользуемых сущностей, при реализации одного интерфейса в нескольких
        //методах, этот интерфейс имеет множество осей изменений: при изменении его методов, 
        //придется переписывать все сущности, его реализующие


        //ХОРОШО
        interface IFlyingAnimal
        {
            void Fly();
        }
       
        interface IWalkingAnimal
        {
            void Walk();
        }

        //только ради удобства можно объединить два интерфейса выше в один
        interface IAnimal
        {
            void Fly();
            void Walk();
        }

        class Animal
        {
            public string Species { get; set; }
            public int LegsCount { get; set; }
        }
       
        class Bird : Animal, IFlyingAnimal, IWalkingAnimal //ИЛИ только IAnimal
        {
            //Здесь все хорошо
            public void Fly()
            {
                //logic
            }
            public void Walk()
            {
                //logic
            }
        }
        class Mosquito : Animal, IFlyingAnimal
        {
            public void Fly()
            {
                //logic
            }
        }

        class Dog : Animal, IWalkingAnimal
        {
            public void Walk()
            {
                //logic
            }
        }








        static void Main(string[] args)
        {

        }
    }
}
