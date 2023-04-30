using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1BackendCourse
{
    internal class Hero
    {
        //Share attributes for all heroes:
        //Name
        //Level - all heroes start at level 1
        //LevelAttribtues - total from all levels
        //Equipment - holds currently equipped items
        //ValidWeaponTypes – a list of weapon types a hero can equip based on their subclass
        //ValidArmorTypes - a list of armor types a hero can equip based on their subclass

        /*Public facing methods: 
         * Constructor – each hero is created by passing just a name.
         * • LevelUp – increases the level of a character by 1 and increases their LevelAttributes
         * • Equip – two variants, for equipping armor and weapons
         * • Damage – damage is calculated on the fly and not stored
         * • TotalAttributes – calculated on the fly and not stored
         * • Display – details of Hero to be displayed
        */

        /*There should be a base abstract Hero class to encapsulate 
         * all the shared functionality (fields and methods).
         * Any methods which have a default implementation can be defined 
         * in this abstract class to be overridden in the child classes.
         * If there is no default implementation for a method, 
         * make it abstract to be implemented in a child class.
         * NOTE: When testing the functionality, you need to interact with the abstract Hero class, and not the subclasses. 
         * This is tosatisfy the Liscov Substitution Principle
         */


}
}
