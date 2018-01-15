
    public class DungeonState:GameState
    {
        protected override void OnStart()
        {
            throw new System.NotImplementedException();
        }

        protected override void OnStop()
        {
            GUIManager.HideView("PlayerPanel");
        }

        protected override void OnLoadComplete()
        {
            GUIManager.ShowView("PlayPanel");
        }
    }
