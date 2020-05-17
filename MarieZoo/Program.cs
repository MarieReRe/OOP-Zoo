using System;
using MarieZoo.Birds;
using MarieZoo.Fish;
using MarieZoo.Mammals;


namespace MarieZoo
{
    /*            My Zoo Needs:
         [x] 1.  Have at least 3 different abstract classes
         [x] 2. Have at least 3 layers of inheritance
         [x] 3.Have at least 5 concrete animals
         [x] 4. Have at least 2 abstract methods (make sure you override them)
         [x] 5. Have at least 2 abstract Properties (make sure you override them
         [x] 6.Have at least 2 virtual methods (make sure you override at least one of them)
         [x] 7. Have at least 2 virtual properties (make sure you override at least one of them)
         [x] 8. Your (digital) drawing of your zoo diagram should be clearly labeled
     */




    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Zoo");


            //create new animal array
            Animals[] animals = new Animals[6];
            Puffin puffin = new Puffin();
            ScarletIbis scarletIbis = new ScarletIbis();
            Seahorse seahorse = new Seahorse();
            Stingray stingray = new Stingray();
            Koala koala = new Koala();
            SnowLeopard snowLeopard = new SnowLeopard();

            //Animal Array Contains 6 animals

            //Bird
            animals[0] = puffin;
            animals[1] = scarletIbis;

            // Fish
            animals[2] = seahorse;
            animals[3] = stingray;


            // Mammals
            animals[4] = koala;
            animals[5] = snowLeopard;


            //for loop to display animals
            for(int i = 0; i < animals.Length; i++)
            {
                animals[i].DisplayCard();
            }
        }


        /* public Puffin()
         {
             List
         }*/

      


    }
}
