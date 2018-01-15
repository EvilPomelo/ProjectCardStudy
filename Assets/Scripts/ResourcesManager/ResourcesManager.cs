using UnityEngine;
public class ResourcesManager:MonoBehaviour
{
    private static ResourcesManager _Instace = null;

    public static ResourcesManager Instance
    {
        get
        {
            if (_Instace==null)
            {
                _Instace=new ResourcesManager();
            }
            return _Instace;
        }
    }

    private string uiPanelPath = "UI/Panel";

    public GameObject GetUIPrefab(string name)
    {
        return LoadPrefab(name,uiPanelPath);
    }

    public GameObject LoadPrefab(string name,string path)
    {
        string loadPath = path + "/" + name;
        GameObject prefab=Resources.Load(loadPath,typeof(GameObject)) as GameObject;
        if (prefab==null)
        {
            Debug.LogError("prefab is null,loadPath" +loadPath);
        }

        return prefab;
    }
}