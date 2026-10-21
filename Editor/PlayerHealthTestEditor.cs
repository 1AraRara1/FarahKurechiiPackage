using UnityEngine;
using UnityEditor;
using Kurechii.Package;

namespace Kurechii.Package.Editor
{
    [CustomEditor(typeof(PlayerHealthTest))]
    public class PlayerHealthTestEditor : UnityEditor.Editor
    {
        // Override the OnInspectorGUI method to customize the inspector
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector(); // Draw the default inspector

            PlayerHealthTest playerHeal = (PlayerHealthTest)target; // Get the target object
            GUIlayout.Space(10); // Add some space in the inspector
            // Add a button to heal the player
            if (GUILayout.button ("Heal Player"))
            {
                playerHeal.Heal(10); // Call the Heal method - 10
            }
        }
    }
}
