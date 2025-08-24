#if UNITY_WEBGL && !UNITY_EDITOR
using System;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;

namespace SFB
{
    public static class StandaloneFileBrowserWebGL
    {
        [DllImport("__Internal")]
        public static extern void UploadFile(string gameObjectName, string methodName, string filter, bool multiple);
        [DllImport("__Internal")]
        public static extern void DownloadFile(string gameObjectName, string methodName, string filename, byte[] byteArray, int byteArraySize);
    }
}
#endif