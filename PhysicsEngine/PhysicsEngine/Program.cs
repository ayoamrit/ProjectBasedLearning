namespace PhysicsEngine
{
    public class Program
    {
        //Init objects
        private static PhysicsEngine.Program program = new Program();
        private BoardHandler.Board board = new BoardHandler.Board();
        private CollisionHandler.Collision collision;

        //Main function
        public static void Main(string[] args)
        {
            program.PerformCollision();
        }

        private void PerformCollision()
        {
            program.collision = new CollisionHandler.Collision();
        }
    }
}