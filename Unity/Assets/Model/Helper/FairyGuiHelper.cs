using FairyGUI;
using UnityEngine;

namespace ETModel
{
    public static class FairyGuiHelper
    {
        static UIPackage.LoadResource _loadFromResourcesPath = (string name, string extension, System.Type type, out DestroyMethod destroyMethod) =>
        {
            destroyMethod = DestroyMethod.Unload;
            AssetBundle assetBundle = AssetBundle.LoadFromFile(name);
            if (null != assetBundle)
            {
                var assets = assetBundle.LoadAllAssets();
                assetBundle.Unload(false);
                return assets[0];
            }
            return null;
        };

        public static void LoadAssetBundle(string path)
        {
            UIPackage.AddPackage(path, _loadFromResourcesPath);
        }

        public static void AddPackage(string packageName)
        {
#if UNITY_EDITOR
            string path = "Assets/Bundles/UI/" + packageName;
            UIPackage.AddPackage(path);
#else
            string root = Application.streamingAssetsPath;
            string path = root + "/ui/" + packageName.ToLower();
            LoadAssetBundle(path);
#endif
        }
    }
}
