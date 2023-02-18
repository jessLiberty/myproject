using System;
using Emgu.CV;
namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat pic = new Mat();
            pic = CvInvoke.Imread(@"C:\Users\User\source\repos\ConsoleApp56\night.jpg");
            Mat gaussianBlur = new Mat();

            CvInvoke.GaussianBlur(pic, gaussianBlur, new System.Drawing.Size(pic.Rows, pic.Cols), 1);

            CvInvoke.Imshow("starry night", pic);
            CvInvoke.Imshow("blurry night", gaussianBlur);

            CvInvoke.WaitKey();
        }
    }
}
