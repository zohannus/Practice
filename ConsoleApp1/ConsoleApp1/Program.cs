namespace ConsoleApp1;

public class Program
{

    public static void Main()
    {
        Managers.Instance.Initialize();

        while (Managers.Run)
        {
            Managers.Instance.Update();
        }

        Managers.Instance.Release();
    }
}
