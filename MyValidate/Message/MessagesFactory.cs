using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.Message
{
    class MessagesFactory
    {
        public static MessagesFactory instance = null;

        private MessagesFactory()
        {
        }

        public static MessagesFactory getInstance()
        {
            if (instance == null)
            {
                instance = new MessagesFactory();
            }
            return instance;
        }

        public MessagesContainer Create()
        {
            return Create(LangCode.en);
        }

        public MessagesContainer Create(LangCode code)
        {
            switch (code)
            {
                case LangCode.en:
                    return new EnglishMessageContainer();
                case LangCode.vi:
                    return new VietnameseMessagesContainer();
                default:
                    return Create(LangCode.en);
            }

        }
    }
}
