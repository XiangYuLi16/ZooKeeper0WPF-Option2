using System;
using System.Windows;

namespace ZooKeeper0WPF
{
    public class Raptor : Animal
    {
        public Raptor(string name)
        {
            this.name = name;
            this.emoji = "🦅"; // Set the emoji specific to raptors
            this.species = "Raptor";
            this.reactionTime = 1; // Raptors have a fast reaction time of 1
            // Assuming all newly created animals initially start in the holding pen, hence (-1, -1) for their starting location
            this.location = new Point(-1, -1);
        }

        public override void Activate()
        {
            // Override the Activate method to show how the raptor behaves
            base.Activate(); // Call the base class's Activate method
            Hunt(); // Display the raptor's hunting behavior
        }

        public void Hunt()
        {
            // Hunting method to show the special hunting behavior of the raptor
            Console.WriteLine($"🦅 {name} swoops down from the sky at ({location.X},{location.Y}) to hunt its prey with unmatched speed.");
        }
    }
}

