using System;

internal class Ghost
{
    public static Ghost instance { get; private set; }

    public Ghost()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Search(HidingSpot[] hidingSpots)
    {
        foreach (HidingSpot hiding in hidingSpots)
        {
            Console.WriteLine($"Le fantôme cherche [{hiding}]");


            if (hidingSpot.visibility < 75)
            {
                Console.WriteLine("Le fantôme vous a trouvé!");
                return;
            }

            Console.WriteLine("Le fantôme vous n'a pas trouvé!");
        }
    }
}
