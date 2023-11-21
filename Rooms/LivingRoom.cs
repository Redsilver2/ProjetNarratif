using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class LivingRoom : Room
    {
        internal override string CreateDescription() => "Dans le salon,  le [Sofa] semble être confortable.\n"
                                                      + "La [Tv] illumine fiablement la salle.\n"
                                                      + "Tu peux revenir dans ta [Chambre]";


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "sofa":
                    Console.WriteLine("tu t'assoies sur le sofa.");
                    break;

                case "tv":
                    Console.WriteLine("Tu regardes la télévision.");
                    Game.Finish();
                    break;
                
                case "chambre":
                    Game.Transition<Bedroom>();
                    break;
            }
        }
    }
}
