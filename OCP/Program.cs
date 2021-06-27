using System;

namespace OCP
{
    // Open–closed principle / Принцип открытости-закрытости
    class Program
    {
        //ПЛОХО
        class Picture
        {
            public double Size { get; set; }
            public DateTime CreationDate { get; set; }

            public void SaveImage()
            {
                //сохранение в формате по умолчанию (jpg)
            }

            //если потребуется сохранение в другом формате - придется изменить этот класс
            public void SaveImageAsPng()
            {
                //сохранение в формате по умолчанию
            }
        }

        //ХОРОШО
        class Picture
        {
            public double Size { get; set; }
            public DateTime CreationDate { get; set; }
            public Picture(double size, DateTime creationDate)
            {
                size = Size;
                creationDate = creationDate;
            }

            public virtual void SaveImage()
            {
                //сохранение в формате по умолчанию (Jpg)
            }
        }

        class ImageAsPng : Picture
        {
            public ImageAsPng(double size, DateTime dateTime) : base(size, dateTime)
            {
            }
            public override void SaveImage()
            {
                //сохранение в формате Png
            }
        }

        class ImageAsBmp : Picture
        {
            public ImageAsBmp(double size, DateTime dateTime) : base(size, dateTime)
            {
            }
            public override void SaveImage()
            {
                //сохранение в формате Bmp
            }
        }

        //ЛИБО через интерфейс
        interface SaveImage
        {
            void SaveImageAs();
        }

        class ImageAsJpeg : SaveImage
        {
            public double Size { get; set; }
            public DateTime CreationDate { get; set; }
           
            public void SaveImageAs()
            {
                //сохранение в формате Jpeg
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
