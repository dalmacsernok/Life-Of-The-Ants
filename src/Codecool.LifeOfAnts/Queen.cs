namespace Codecool.LifeOfAnts
{
    public class Queen : Ant
    {
        public bool Mood { get; set; }

        public Queen(Position position) : base(position)
        {
            Mood = false;
        }

        public override void Act(int width, int antsNum)
        {
            throw new System.NotImplementedException();
        }



    }
}
