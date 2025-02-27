using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_02
{
    public class Managers
    {
        private static Managers instance = null;

        public static Managers Instance
        {
            get
            {
                if (instance == null)
                CreateInstance();

                return instance;
            }
        }

        private List<IManager> _manager = new List<IManager>();
        private Skill_Info _skill;

        public static Skill_Info Skill { get => Instance._skill; }
        public static bool Run { get; private set; } = true;

        private static void CreateInstance()
        {
            instance ??= new Managers();
        }

        public void Initialize()
        {
            _skill ??= new Skill_Info();
            _manager.Add(_skill);
        }

        public void Update()
        {

        }
        public void Release()
        {

        }
    }

   
}
