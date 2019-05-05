namespace Pattern.Strategy.Choice
{
    public class Context
    {
        private IChoice _choice;
        /* It's our choice. We prefer to use a setter method instead of
        using a constructor. We can call this method whenever we want to
        change the "choice behavior" on the fly. */

        public void SetChoice(IChoice choice)
        {
            _choice = choice;
        }

        /* This method will help us to delegate the particular
        object's choice behavior/characteristic. */

        public void ShowChoice()
        {
            _choice.SelectedChoice();
        }
    }
}
