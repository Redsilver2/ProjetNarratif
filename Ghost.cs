using System;

namespace ProjetNarratif {
    public class Ghost
    {
        public bool Spawn()
        {
            int chances = new Random().Next(0, 100);

            if(chances > 80)
            {
                return true;
            }

            return false;
        }

        public void Search(HidingSpot[] hidingSpots, HidingSpot currentHidingSpot)
        {
            Console.WriteLine();

            foreach (HidingSpot hidingSpot in hidingSpots)
            {
                Console.WriteLine($"Le fantôme cherche [{hidingSpot.name}]");


                if (hidingSpot.visibility < 60 && currentHidingSpot.name.ToLower() == hidingSpot.name.ToLower())
                {
                    Console.WriteLine("Le fantôme vous a trouvé!");
                    Game.Finish();
                    return;
                }

                Console.WriteLine("Le fantôme vous n'a pas trouvé!");
            }
        }
    }
}
