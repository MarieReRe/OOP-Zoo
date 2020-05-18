using System;
using MarieZoo.Birds;
using MarieZoo.Fish;
using Xunit;
using MarieZoo.Interfaces;
using MarieZoo.Mammals;
using Xunit.Sdk;

namespace MarieZoo.Test
{
    public class NoAnimalTesting

    {
        /* -------------------BIRD SECTION-------------------------
         ---------------------------------------------------------*/
        [Fact]
        public void PuffinInheritsBehavior()
        {
            //arrange
            Puffin puffin = new Puffin() { Name = "Puff Diddy" };

            // act
            string expected = $"{puffin.GetMakeSound()}";
            string input = puffin.GetMakeSound();

            //assert
            Assert.Equal(expected,input);

        }

        [Fact]
        public void ScarletIbisFeeding()
        {
            //arrange
            ScarletIbis scarletIbis = new ScarletIbis();
            //act

            //assert
            Assert.True(scarletIbis.YouCanFeedMe());

        }








        /* -------------------FISH SECTION-------------------------
       ---------------------------------------------------------*/
        [Fact]
        public void TestingSeahorseInheritsBehavior()
        {
            //Arrange
            Seahorse seahorse = new Seahorse() { Name = "Sven" };

            //Act
            string input = seahorse.Predator();

            string expected = $"{seahorse.Predator()}";

            //Assert
            Assert.Equal(expected, input);

        }

        [Fact]
        public void TestingStingrayInheritsBehavior()
        {
            Stingray stingray = new Stingray();

            //Act
            string input = stingray.Predator();
            string expected = $"{stingray.Predator()}";

            //assert
            Assert.Equal(expected, input);
        }

        [Fact]
        public void StingraysSwimInheritedFromFishClass()
        {
            Stingray stingray = new Stingray();
            string input = "We do lots of swimming, swimming all day! Just keep swimming, just keep swimming.What do we do we swim,swim....";
            string expected = stingray.Swim();


            //assert
            Assert.Equal(expected, input);
        }


        /* -------------------MAMMAL SECTION-------------------------
   ---------------------------------------------------------*/
        [Fact]
        public void KoalaLengthInInches()
        {
            Koala koala = new Koala();

            decimal expected = koala.LengthInInches;
            decimal input = 30;

            //Assert
            Assert.Equal(expected, input);
        }


    }
}
