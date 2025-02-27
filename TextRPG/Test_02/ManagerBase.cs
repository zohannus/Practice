using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_02
{
    public interface IManager
    {
        public void Initialize();

        public void Update();

        public void Release();
    }
}
