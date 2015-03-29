using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    class MyConfigurationManager
    {
        private static object lockObject = new object();
        private static MyConfigurationManager instance;

        //EN : Private members. You can give a reference for the other objects / TR : Erişime kapalı alanlar. Diğer nesnelere referans verebilirsiniz.
        private static string parameterA;
        private static int parameterB;

        //EN : Private constructor. / TR : Erişime kapalı "Contructor"
        private MyConfigurationManager()
        {

        }


        //EN : Static Property to access the singleton class / TR : Sttik özellik, singleton nesnesine erişmek imkanı sağlar.
        public static MyConfigurationManager Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                        instance = Initialize();
                }

                return instance;
            }
        }


        public string ParameterA
        {
            get { return parameterA; }
            //EN : We should be careful for global data. "Set" part may be closed. TR : Global verinin kullanımasında dikkat etmeliyiz. "Set" kısmı kapatılabilir.
            private set { parameterA = value; } // EN : Notice private. Set has been closed for punlic operations / TR : "private" ifadesine dikkat ediniz. "Set", herkese açık olmaktan, kapatılmıştır.
        }

        public int ParameterB
        {
            get { return parameterB; }
            //EN : We should be careful for global data. "Set" part may be closed. TR : Global verinin kullanımasında dikkat etmeliyiz. "Set" kısmı kapatılabilir.
            private set { parameterB = value; } // EN : Notice private. Set has been closed for punlic operations / TR : "private" ifadesine dikkat ediniz. "Set", herkese açık olmaktan, kapatılmıştır.
        }


        
        private static MyConfigurationManager Initialize()
        {
            MyConfigurationManager configurationManager = new MyConfigurationManager();

            //EN : Get property values from different resources. Set initial values in this case. 
            // TR : Özellik değerlerinin, başka kaynaklardan alınması. Bu durumda, ilk değerler verilmesi

            configurationManager.ParameterA = "PArametreA";
            configurationManager.ParameterB = 100;

            return configurationManager;
        }
    }
}
