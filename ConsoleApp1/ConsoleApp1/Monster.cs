namespace ConsoleApp1
{
    public class Monster
    {

        // get; private set;형태는
        // 가져가는것은 public 이지만 HP를 수정하는것은 이 클래스(private) 밖에 못한다는것을 의미
        public int HP { get; private set; }
        public int Attack { get; private set; }

        public void Initialize()
        {
            HP = 10;
            Attack = 1;
        }
    }
}
