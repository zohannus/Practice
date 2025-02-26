using System.Collections.Generic;

namespace ConsoleApp1
{
    // 매니저들 관리하는 클래스
    public class Managers
    {
        private static Managers sInstance = null;
        public static Managers Instance
        {
            get
            {
                if (sInstance == null)
                    CreateInstance();

                return sInstance;
            }
        }


        #region ## Managers ##
        private List<IManager> _managers = new List<IManager>();
        private GameManager _game;
        private UIManager _ui;

        public static GameManager Game { get => Instance._game; }
        public static UIManager UI { get => Instance._ui; }
        #endregion

        #region ## Fields ##
        /// <summary>프로그램 실행중인지?</summary>
        public static bool Run { get; private set; } = true;
        #endregion

        private static void CreateInstance()
        {
            sInstance ??= new Managers();
        }

        public void Initialize()
        {
            if (_ui == null)
            {
                _ui = new UIManager();
                _managers.Add(_ui);
            }

            if (_game == null)
            {
                _game = new GameManager();
                _managers.Add(_game);
            }

            for (int i = 0; i < _managers.Count; i++)
            {
                _managers[i].Initialize();
            }
        }

        /// <summary>프로그램을 종료 할 때 해당 함수를 호출하면 된다.</summary>
        public void Release()
        {
            for (int i = 0; i < _managers.Count; i++)
            {
                _managers[i].Release();
            }
        }

        public void Update()
        {
            for (int i = 0; i < _managers.Count; i++)
            {
                _managers[i].Update();
            }
        }
        
        public void StopProgram()
        {
            Run = false;
        }
    }
}
