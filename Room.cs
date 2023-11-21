namespace ProjetNarratif
{
    internal abstract class Room
    {
        internal abstract string CreateDescription();

        internal virtual void ReceiveChoice(string choice)
        {
            Ghost ghost = Game.GetGhost();

            if (ghost.Spawn())
            {
                Console.WriteLine();
                Console.WriteLine("Voici la liste des cachettes");

                for (int i = 0; i < hidingSpots.Length; i++)
                {
                    HidingSpot hidingSpot = hidingSpots[i];
                    Console.WriteLine($"Il y a [{hidingSpot.name}] avec une visibilité de {hidingSpot.visibility}");
                }


                ghost.Search();
            }
            else
            {

            }
        }

        public HidingSpot FindHidingSpot()
        {
            while (true)
            {
                string input = Console.ReadLine();

                for (int i = 0; i < hidingSpots.Length; i++)
                {
                    HidingSpot hidingSpot = hidingSpots[i];

                    if (input.ToLower() == hidingSpot.name.ToLower())
                    {
                        return hidingSpot;
                    }
                }

                Console.WriteLine("Ce n'est pas un endroit valide!");
            }

            return new HidingSpot();
        }

        private HidingSpot[] hidingSpots;

        public void CreateHidingSpots(HidingSpot[]  hidingSpots) => this.hidingSpots = hidingSpots;
    }

    public struct HidingSpot
    {
        public string name { get; private set; }
        public float visibility { get; private set; }
        public string description { get; private set; }

        public HidingSpot(string name, float visibility, string description)
        {
            this.name = name;
            this.visibility = visibility;
            this.description = description; 
        }
    }
}
