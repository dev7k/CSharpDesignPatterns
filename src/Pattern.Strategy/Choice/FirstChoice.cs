using System;

namespace Pattern.Strategy.Choice
{
    public class FirstChoice : IChoice
    {
        public void SelectedChoice()
        {
            Console.WriteLine("First choice.");
        }
    }
}
