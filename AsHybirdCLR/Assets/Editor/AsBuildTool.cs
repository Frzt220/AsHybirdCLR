using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AsBuildTool : Editor
{
    [MenuItem("DM/打包AB包")]
    static void MakeHotDll() {
        exportAssetBundle();
    }
    public static void exportAssetBundle() {
        BuildAssetBundleOptions option = BuildAssetBundleOptions.None;
        //打包资源
        AssetBundleManifest maniFest = BuildPipeline.BuildAssetBundles(
            getAssetExportFolderFullPath()
            , option
            , EditorUserBuildSettings.activeBuildTarget);
        if (null == maniFest) {
            Debug.LogError("打包热更dll失败");
        }
    }

    public static string getAssetExportFolderFullPath() {
        return "Assets/DllAB/";
    }
}
