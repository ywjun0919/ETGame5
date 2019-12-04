using UnityEngine;

namespace ETModel
{
    [Event(EventIdType.LoadingBegin)]
    public class LoadingBeginEvent_CreateLoadingUI : AEvent
    {
        public override void Run()
        {
            FUI.Open(typeof(LoadingUI));
        }
    }
}
