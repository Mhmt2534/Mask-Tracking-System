using Business.Concrete;
using Entities;
using Entities.Concrete;

namespace WorkAround
{
    public class Program
    {
        static void Main()
        {

            //string[] sehir1 = new[] { "Ankara", "İstanbul", "İzmir","dasdas" };
            //string[] sehir2 = new[] { "Bursa", "Antalya", "Mersin" };

            //sehir2 = sehir1;
            //sehir1[0] = "Adana";

            //Console.WriteLine(sehir1[0]);

            //List(sehir1, "Adana"); //List olmasa

            /*
            Console.WriteLine("");

            List<string> yeniSehirler= new List<string> { "Ankara","Istanbul","Izmir"};
            yeniSehirler.Add("Adana");
            foreach(string sehir in yeniSehirler)
            {
                Console.WriteLine(sehir+"\n");
            }
            */

            Person person1 = new Person();
            person1.FirstName = "Mahmut";
            person1.LastName = "Güneş";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 123;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            
        }











        //Eğer Listeler olmasa böyle yapabilirdik.Döndürülmüş hali için void yerine String[] yazılıp dizi döndürülürdü.
        static void List(string[] Arr,string cityToAdd)
        {
            int s=Arr.Length;

            string[] af=new string[s];

            for (int i = 0; i < Arr.Length; i++)
            {
                af[i] = Arr[i];
            }

            Arr=new string[s+1];
            Arr[s] = cityToAdd;

            for (int i = 0; i < s; i++)
            {
                Arr[i] = af[i];
         
            }

            for (int i = 0; i < s+1; i++)
            {
                Console.WriteLine(Arr[i]);
                Console.WriteLine("");
            }
            
        }

    }
}
