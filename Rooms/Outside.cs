using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetNarratif.Rooms
{
    internal class Outside : Room
    {
        internal override string CreateDescription() => "Vous voyez une [Maison]" + 
                                                        "Votre voitre";

        internal HidingSpot[] hidingSpots = new HidingSpot[2]
        {
            new HidingSpot("Voiture", 50, "Vous vous cachez derrière la voiture"),
            new HidingSpot("Maison" , 90, "Vous courez et vous cachez"),
        };

        internal override void ReceiveChoice(string choice)
        {
            Game.GetGhost().Spawn();
        }
    }
}
