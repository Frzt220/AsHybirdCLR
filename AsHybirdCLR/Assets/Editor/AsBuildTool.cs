using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AsBuildTool : Editor
{
    [MenuItem("DM/���AB��")]
    static void MakeHotDll() {
        exportAssetBundle();
    }
    public static void exportAssetBundle() {
        BuildAssetBundleOptions option = BuildAssetBundleOptions.None;
        //�����Դ
        AssetBundleManifest maniFest = BuildPipeline.BuildAssetBundles(
            getAssetExportFolderFullPath()
            , option
            , EditorUserBuildSettings.activeBuildTarget);
        if (null == maniFest) {
            Debug.LogError("����ȸ�dllʧ��");
        }
    }

    public static string getAssetExportFolderFullPath() {
        return "Assets/DllAB/";
    }
}
