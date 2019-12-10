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
            string root = Application.streamingAssetsPath;
            LoadAssetBundle(root + "/ui/" + packageName);
        }
    }
}
