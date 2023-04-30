using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1BackendCourse
{
    public class HeroAttribute
    {
        /*Strength – determines the physical strength of the character.
        *• Dexterity – determines the characters ability to attack with speed and nimbleness.
        *• Intelligence – determines the characters affinity with magic.
        *
        *This class should have methods to add two instances together and return the sum 
        *OR increase the one instance by a specified amount. 
        *Which to use is up to you on what best suits your solution.
        *EB: make virtual method in abstract Hero class for levellingup, override here so that when level increases, strength, decterity and inteligence increases
        *
        *NOTE: This class is used as the datatype for both LevelAttributes.
        *
        *From Armor class: 
        *In addition to an armor type, armor has attributes which provide bonuses to a heroes attributes when equipped. 
        *This field is of type HeroAttribute and should be called ArmorAttribute.
        */

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int ArmorAttribute { get; set; }
    }
}
