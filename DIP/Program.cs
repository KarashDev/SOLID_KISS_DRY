using System;
using System.Collections.Generic;
using System.Linq;

namespace DIP
{
    //Dependency inversion principle / Принцип инверсии зависимостей
    class Program
    {
        //=================ПРИМЕР 1=======================

        //ПЛОХО
        ////абстракции здесь напрямую зависят от деталей (классы и методы зависят от 
        ////определенной сущности внутри них. А что если мы захотим отправить
        ////не только email, а что-то другое?
        //public class Email
        //{
        //    public void Send()
        //    {
        //        //send
        //    }
        //}

        //public class Notification
        //{
        //    public Email email;

        //    public void EmailDistribution()
        //    {
        //        email.Send();
        //    }
        //}

        ////ХОРОШО
        //public interface ISender
        //{
        //    void Send();
        //}

        //class Email : ISender
        //{
        //    public void Send()
        //    {
        //        //send email
        //    }
        //}
        //class SMS : ISender
        //{
        //    public void Send()
        //    {
        //        //send SMS
        //    }
        //}
        ////вариант с Constructor Injection
        //public class Notification
        //{
        //    ISender sender;

        //    public Notification(ISender sender)
        //    {
        //        this.sender = sender;
        //    }
        //    public void Distribution()
        //    {
        //        sender.Send();
        //    }
        //}
        ////вариант с Method Injection
        ////public class Notification
        ////{
        ////    public void Distribution(ISender sender)
        ////    {
        ////        sender.Send();
        ////    }
        ////}

        //=================ПРИМЕР 2=======================

        //ПЛОХО
        //этот метод зависит от типа данных переданного аргумента
        //static int Max(int[] array)
        //{
        //    if (array.Length == 0) return default(int);
        //    else return array.Max();
        //}
        //Console.WriteLine(Max(new[] { 3, 1, 2 }));

        //ХОРОШО
        //теперь метод менее зависим от вариаций переданного параметра
        //static T Max<T>(T[] array)
        //   where T : IComparable
        //{
        //    if (array.Length == 0)
        //        return default(T);

        //    else return array.Max();
        //}
        //Console.WriteLine(Max(new int[0]));
        //Console.WriteLine(Max(new[] { 3 }));
        //Console.WriteLine(Max(new[] { 3, 1, 2 }));
        //Console.WriteLine(Max(new[] { "A", "B", "C" }));



        static void Main(string[] args)
        {
         





        }
    }
}
