﻿    public class CityState:GameState
    {
        protected override void OnStart()
        {
            throw new System.NotImplementedException();
        }

        protected override void OnStop()
        {
           GUIManager.HideView("CityPanel");
        }

        protected override void OnLoadComplete()
        {
            GUIManager.ShowView("CityPanel");
        }
    }
