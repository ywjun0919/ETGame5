namespace ETModel
{
    [Event(EventIdType.LoadingFinish)]
    public class LoadingFinishEvent_RemoveLoadingUI : AEvent
    {
        public override void Run()
        {
            FUI.Close(typeof(LoadingUI));
			//Game.Scene.GetComponent<UIComponent>().Remove(UIType.UILoading);
        }
    }
}
