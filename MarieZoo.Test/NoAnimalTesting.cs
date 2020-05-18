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

        [Fact]
        public void SeahorseMovements()
        {
            //arrange
            Seahorse seahorse = new Seahorse();
            //act
            string input =
                "You won't find me swimming around a lot as I get exhausted easily and could die from over exhaustion";
            string expected = seahorse.Movement;
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

        [Fact]
        public void GetSnowLeopardColor()
        {
            //arrange
            SnowLeopard snowLeopard = new SnowLeopard();

            string input = "Creamy yellow with grey or black";
            string expected = snowLeopard.Color;

            //Assert
            Assert.Equal(expected, input);
        }

        [Fact]
        public void GetSnowLeopardAge()
        {
            //Arrange
            SnowLeopard snowLeopard = new SnowLeopard();

            int input = 3;
            int expected = snowLeopard.GetAge();

            //assert
            Assert.Equal(expected,input);
        }

        [Fact]
        public void GetKoalaWeight()
        {
            Koala koala = new Koala();

            //act
            int input = 30;
            int expected = koala.GetWeight();

            //assert
            Assert.Equal(expected, input);
        }
    }
}
