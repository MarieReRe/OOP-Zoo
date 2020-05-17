using System;
using MarieZoo.Birds;
using Xunit;
using MarieZoo.Interfaces;

namespace MarieZoo.Test
{
    public class NoAnimalTesting

    {
        /* -------------------ANIMAL SECTION-------------------------
       ---------------------------------------------------------*/


        /* -------------------BIRD SECTION-------------------------
         ---------------------------------------------------------*/
        [Fact]
        public void PuffinInheritsBehavior()
        {
            //arrange
            Puffin puffin = new Puffin() { Name = "Puff Diddy" };

            // act
            string expected = ($"{puffin.GetMakeSound()}");
            string input = puffin.GetMakeSound();

            //assert
            Assert.Equal(expected,input);

        }






        /* -------------------MAMMAL SECTION-------------------------
       ---------------------------------------------------------*/









        /* -------------------FISH SECTION-------------------------
       ---------------------------------------------------------*/


        /* -------------------INTERFACE SECTION-------------------------
       ---------------------------------------------------------*/
    }
}
