using System;

namespace ClassWork_03_31_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //string photo = "https://media.moddb.com/images/members/5/4550/4549205/duck.jpg";
            //string photo1 = "https://www.pexels.com/photo/bird-s-eye-view-of-city-2246476";
            ////PhotoName(photo);
            ////PhotoName(photo1);
            //Guid myUUId = Guid.NewGuid();
            //string convertedUUID = myUUId.ToString();
            //Console.WriteLine("Current UUID is: " + convertedUUID);
            //Console.WriteLine(convertedUUID.Length);
            #endregion

        

        }
        #region
        static void PhotoName(string photo)
        {
            string[] strlist = photo.Split("/");
            Console.WriteLine(strlist[strlist.Length - 1]);
        }
        #endregion
    }
}
