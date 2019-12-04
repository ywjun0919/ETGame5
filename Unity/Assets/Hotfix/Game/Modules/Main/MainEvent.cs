using ETModel;

namespace ETHotfix
{
    [Event(EventIdType.LoginFinish)]
    class MainEvent : AEvent
    {
        public override void Run()
        {
            FUI.Open(typeof(DlgMain));
        }
    }
}
