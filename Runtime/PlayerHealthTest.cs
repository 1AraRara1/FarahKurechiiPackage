using UnityEngine;

namespace Kurechii.Package
{
    public static class PlayerHealthTest: MonoBehaviour
    {
        // Declare variables
        public int currentHealth = 50;
        public int maxHealth = 100;

        // Function to add health (heal)
        public void Heal (int amount)
        {
            currentHealth = Mathf.Min(currentHealth + amount, maxHealth);

            Debug.Log ("Player Healed!! Current Health: " + currentHealth);
        }
    }
}