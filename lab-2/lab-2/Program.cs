using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Object Instance
            //Sosial sosial = new Sosial();
            //sosial.Fb = "facebbok";
            //sosial.Insta = "INsttagram";
            //sosial.Link = "Linkedin";


            //Teachers teachers4= new Teachers();
            //teachers4.Name = "test4";
            //teachers4.Surname = "test4";
            //teachers4.age = 4;
            //teachers4.sosial = sosial;
            //teachers4.sosial.Fb = "facebbook4";


            //Teachers teachers3 = new Teachers();
            //teachers3.Name = "test3";
            //teachers3.Surname = "test3";
            //teachers3.age = 3;
            //teachers3.sosial = new Sosial();


            //Teachers teachers2 = new Teachers();
            //teachers2.Name = "test2";
            //teachers2.Surname = "test2";
            //teachers2.age = 2;
            //teachers2.sosial = sosial;



            //Console.WriteLine($"{teachers3.Name} {teachers3.sosial.Fb}");
            ////Console.WriteLine($"{teachers2.Name} {teachers2.sosial.Fb}");

            ////Console.WriteLine($"{teachers4.Name} {teachers4.sosial.Fb}");



            ////Teachers teachers1 = new Teachers();
            ////teachers1.Name = "test1";
            ////teachers1.Surname = "test1";
            ////teachers1.age = 1;
            ////teachers1.sosial = new Sosial();
            ////teachers1.sosial.Fb = "Facebook1";

            #endregion

            string[] strarr = new string[4];




            for (int i = 0; i < strarr.Length; i++)
            {
                strarr[i] = Console.ReadLine();
            }

            Sum sum = new Sum();
            sum.Arry(strarr);


            #region task-2
            //double[] ar = new double[10];

            //for (int i = 0; i < ar.Length; i++)
            //{
            //    ar[i] = int.Parse(Console.ReadLine());    
            //}

            //Sum sum = new Sum();
            //sum.Hesap(ar);
            #endregion
        }
      

    



       
    }
}
