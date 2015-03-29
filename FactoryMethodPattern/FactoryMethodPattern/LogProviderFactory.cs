using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    public class LogProviderFactory
    {

        #region Methods

        public static ILogProvider GetNewLogProvider(String logProviderType)
        {
            ILogProvider logProvider = null;

            switch (logProviderType)
            {
                case "DB":
                    logProvider = new DBLogProvider();
                    break;
                case "FILE":
                    logProvider = new TextFileLogProvider();
                    break;
                default:
                    throw new ApplicationException("Invalid Type for Log provider/ Log kaynağı için, geçersiz Tip");
            }

            return logProvider;
        }

        #endregion

    }
}
