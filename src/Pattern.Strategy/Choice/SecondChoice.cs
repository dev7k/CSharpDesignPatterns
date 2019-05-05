using System;

namespace Pattern.Strategy.Choice
{
    public class SecondChoice : IChoice
    {
        public void SelectedChoice()
        {
            Console.WriteLine("Second choice.");
        }
    }
}
