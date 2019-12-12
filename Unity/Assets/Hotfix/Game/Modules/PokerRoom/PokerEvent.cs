using System;
using ETModel;

namespace ETHotfix
{
    [Event(EventIdType.PokerRoomOpen)]
    class PokerEvent : AEvent
    {
        public override void Run()
        {
            FUI.Open(typeof(DlgPokerRoom));
        }
    }
}
