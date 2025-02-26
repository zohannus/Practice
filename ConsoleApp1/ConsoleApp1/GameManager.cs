namespace ConsoleApp1
{
    public class GameManager : IManager
    {
        #region ## IManager ##
        public void Initialize()
        {

        }

        public void Update()
        {
            WaitForInput();
        }

        public void Release()
        {

        }
        #endregion

        private void WaitForInput()
        {
            var temp = Console.ReadLine();

            if (temp == "1")
            {
                Managers.UI.ChangeUI(UIType.Basic);
            }
            else if (temp == "2")
            {
                Managers.UI.ChangeUI(UIType.Store);
            }
        }

    }
}
