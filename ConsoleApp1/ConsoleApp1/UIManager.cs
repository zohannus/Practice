using System.Text;

namespace ConsoleApp1
{
    public enum UIType
    {
        Basic, Store
    }

    public class UIManager : IManager
    {
        private const string Line = "==============================";
        private StringBuilder _prevStringBuilder = new StringBuilder();
        private StringBuilder stringBuilder = new StringBuilder();

        #region ## IManager ##
        public void Initialize()
        {
            ChangeUI(UIType.Basic);
        }

        public void Update()
        {
            RenderUI();
        }

        public void Release()
        {

        }
        #endregion

        public void RenderUI()
        {
            if (_prevStringBuilder.ToString() != stringBuilder.ToString())
            {
                _prevStringBuilder.Clear();
                _prevStringBuilder.Append(stringBuilder.ToString());

                Console.Clear();
                Console.Write(stringBuilder.ToString());
            }
        }


        public void ChangeUI(UIType type)
        {
            stringBuilder.Clear();

            switch (type)
            {
                case UIType.Basic:
                    stringBuilder.Append($"싱글톤 패턴 - {type.ToString()}\n\n");
                    
                    stringBuilder.Append(Line);
                    stringBuilder.Append($"\n1 또는 2를 입력해주세요.\n");
                    break;
                case UIType.Store:
                    stringBuilder.Append($"싱글톤 패턴 - {type.ToString()}\n\n");

                    stringBuilder.Append(Line);
                    stringBuilder.Append($"\n1 또는 2를 입력해주세요.\n");
                    break;
            }

        }


    }
}
