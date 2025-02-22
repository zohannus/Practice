class MainGate
{
    static HangMan hangMan = null;
    static Hangman2 hangMan2 = null;
    static void Main()
    {
        hangMan = new HangMan();
        hangMan2 = new Hangman2();
        hangMan.Main();
        //hangMan2.Main();
    }
}