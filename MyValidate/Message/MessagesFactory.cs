using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.Message
{
    class MessagesFactory
    {
        private MessagesFactory()
        {
        }

        public static MessagesContainer Create()
        {
            return Create(LangCode.en);
        }

        public static MessagesContainer Create(LangCode code)
        {
            switch (code)
            {
                case LangCode.en:
                    return new MessagesContainer();
                case LangCode.vi:
                    return new MessagesContainer();
                default:
                    return Create(LangCode.en);
            }

        }
    }
}
