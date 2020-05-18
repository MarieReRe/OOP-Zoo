using MarieZoo.Interfaces;



namespace MarieZoo.Birds
{
    public class ScarletIbis : Bird, IDesign, ISound, IFeed
    {

        public override string Name { get; set; }

        public string FeedMe { get; set; } = " Purchase a bag of live shrimp at the counter for $5";


        public override string Predator()
        {
            return "We are hunted for bush meat";
        }

        public override string FunFact()
        {
            return "We are listed as an environmentally sensitive species";
        }

        public decimal LengthInInches => 17;

        public string Color => "Neon pink with black wing tips";

        public string LegsOrFins => "Two neon pink thin, straw-like legs";

        public string Movement => "Walking and flying around the shorelines of Trinidad";

       

        public override string ColorOfEggs()
        {
           return "we lay pale green eggs that have brown streaks";
        }

        public string GetMakeSound()
        {
           return "cutest bird noise ever!";
        }

        public override string NestingHabits()
        {
           return "We build our nests in trees";
        }

        

       

      
    }
}
