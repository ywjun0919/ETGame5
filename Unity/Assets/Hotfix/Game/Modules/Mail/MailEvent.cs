using ETModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHotfix
{
    [Event(EventIdType.MailOpen)]
    class MailEvent : AEvent
    {
        public override void Run()
        {
            FUI.Open(typeof(DlgMail));
        }
    }
}
