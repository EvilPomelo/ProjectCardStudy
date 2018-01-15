
    public class BattleState:GameState
    {
        protected override void OnStart()
        {
            throw new System.NotImplementedException();
        }

        protected override void OnStop()
        {
            GUIManager.HideView("BattlePanel");
        }

        protected override void OnLoadComplete()
        {
            GUIManager.ShowView("BattlePanel");
        }
    }
