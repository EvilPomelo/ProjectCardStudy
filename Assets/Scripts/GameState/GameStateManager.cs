using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
public class GameStateManager:MonoBehaviour
{
    private static Dictionary<string,GameState> m_GameStateMap=null;
    private static GameState m_CurState = null;
    
    private void Start()
    {
        m_GameStateMap=new Dictionary<string,GameState>();
    }

    private static void SetState(GameState state)
    {
        if (state==null)
        {
            return;
        }

        if (state!=m_CurState&&m_CurState!=null)
        {
            m_CurState.Stop();
        }

        m_CurState = state;
        m_CurState.Start();
    }

    public static void LoadScene(int sceneId)
    {
        //todo:根据sceneID获取data值
        SceneData data = null;
        if (data==null)
        {
            Debug.Log("Init SceneData is null,id:"+sceneId);
        }

        GameState state = null;
        //字典中如果没找到state对象则
        if (!m_GameStateMap.TryGetValue(data.GameState,out state))
        {
            state=Assembly.GetExecutingAssembly().CreateInstance(data.GameState) as  GameState;
            if (state == null)
            {
                Debug.LogError("Scene State is error"+data.GameState);
            }
            m_GameStateMap.Add(data.GameState,state);
        }
        SetState(state);
        DownloadManager.Instance.LoadScene(data.LevelName,state.LoadComplete);
    }
    
}