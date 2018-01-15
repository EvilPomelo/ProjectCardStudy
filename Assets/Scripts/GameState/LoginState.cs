
    public class LoginState:GameState
    {
        protected override void OnStart()
        {
            throw new System.NotImplementedException();
        }

        protected override void OnStop()
        {
            GUIManager.HideView("LoginPanel");
        }

        protected override void OnLoadComplete()
        {
            GUIManager.ShowView("LoginPanel");
        }
    }
