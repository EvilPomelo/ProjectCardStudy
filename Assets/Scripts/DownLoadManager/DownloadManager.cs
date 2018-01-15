using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DownloadManager : MonoBehaviour
    {
        private static DownloadManager _Instance;

        public static DownloadManager Instance
        {
            get
            {
                if (Instance==null)
                {
                    _Instance = FindObjectOfType(typeof(DownloadManager)) as  DownloadManager;
                }

                return _Instance;
            }

        }
        public delegate void LoadCallBack(params object[] args);
        public void LoadScene(string name,LoadCallBack loadHandler,params object[] args)
        {
            StartCoroutine(LoadSceneBundle(name, loadHandler, args));
        }

        private IEnumerator LoadSceneBundle(string name,LoadCallBack loadHandler,params object[] args)
        {
            AsyncOperation async = SceneManager.LoadSceneAsync(name);
            yield return async;
            Resources.UnloadUnusedAssets();
            GC.Collect();
            if (loadHandler!=null)
            {
                loadHandler(args);
            }
        }


    }
