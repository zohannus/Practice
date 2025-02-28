using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_02
{
    public enum UIType
    {
        Main, Store, Bag
    }
    public class UIManager :IManager
    {
        private const string Line = "================================";
        private StringBuilder _prevStringBuilder = new StringBuilder();
        private StringBuilder stringBuilder = new StringBuilder();

        public void Initialize()
        {
            ChangeUI(UIType.Bag);
        }

        public void Update()
        {
            RenderUI();
        }

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

        public void Release()
        {

        }

        public void ChangeUI(UIType type)
        {
            stringBuilder.Clear();
            switch (type)
            {
                case UIType.Main:
                    stringBuilder.Append("환영합니다.");
                    stringBuilder.Append(Line);
                    stringBuilder.Append("1.사냥터 \n2.상점 \n3.가방");
                    break;
                case UIType.Store:
                    stringBuilder.Append("상점");
                    stringBuilder.Append("1.구매");
                    stringBuilder.Append("2.판매");
                    stringBuilder.Append("3.나가기");
                    break;
                case UIType.Bag:
                    stringBuilder.Append($"가방에 든 물건 갯수 :");
                    break;
            }
        }
    }
}
