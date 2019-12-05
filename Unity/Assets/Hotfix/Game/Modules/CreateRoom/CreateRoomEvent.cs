using ETModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHotfix
{
    [Event(EventIdType.RoomOpen)]
    class CreateRoomEvent : AEvent
    {
        public override void Run()
        {
            FUI.Open(typeof(DlgCreateRoomWinFrame));
        }
    }
}
