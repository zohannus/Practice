namespace ConsoleApp1
{
    public interface IManager
    {
        /// <summary>초기화 함수. 프로그램 시작 시 호출</summary>
        public void Initialize();
        /// <summary>업데이트 함수. 매 프레임마다 호출됨</summary>
        public void Update();
        /// <summary>정리하는 함수. 프로그램 종료 시 호출</summary>
        public void Release();
    }
}
