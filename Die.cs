using System;

namespace DiceGame
{
    internal class Die
    {
        //private member fields
        private int _sides;
        private int _facevalue;

        //public Accessors and Mutators
        public int Sides
        {
            get { return _sides; }
            set
            {
                if (value >= 4)
                {
                    _sides = value;
                }
                else
                {
                    throw new Exception("Invalid sides for a die");
                }
            }
        }//end of Sides

        public int Facevalue
        {
            get { return _facevalue; }
            set
            {
                if(value > 0 && value <= _sides)
                {
                    _facevalue = value;
                }
                else
                {
                    throw new Exception("Invalid face value for a die");
                }
            }
        }//end of FaceValue

        //constructors 
        public Die()
        {
            Sides = 6;
            Facevalue = 1;
        }

        public Die(int sides)
        {
            Sides = sides;
            Facevalue = 1;
        }

        //class methods
        public void Roll()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            Facevalue = random.Next(1, Sides + 1);
        }//end of roll

        public int AddDie(Die die2)
        {
            return Facevalue + die2.Facevalue;
        }//end of AddDie
    }
}
