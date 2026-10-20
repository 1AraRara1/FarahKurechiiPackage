using UnityEditor;
using Kurechii.Package;

namespace Kurechii.Package.Editor
{
    public class FarahPackageMenu
    {
        [MenuItem("Tools/Farah Kurechii Package/Log Hello")]
        public static void LogHelloMenu()
        {
            FarahPackage.LogHello();
        }
    }

}
