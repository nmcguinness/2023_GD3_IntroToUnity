using System.Collections;
using TMPro;
using UnityEngine;

namespace GD
{
    public class TextAnimationBehaviour : MonoBehaviour
    {
        // Reference to the TextMeshPro component in the Unity Inspector
        public TextMeshPro textMeshPro;

        // The full text to be displayed
        public string fullText = "This is an animated string";

        // Delay before starting the animation
        public float startDelay = 1;

        // Delay between displaying each letter
        public float interLetterDelay = 0.25f;

        // Start is called before the first frame update
        private void Start()
        {
            // Check if the TextMeshPro reference is not null
            if (textMeshPro != null)
            {
                // Assign an empty string to begin
                textMeshPro.text = string.Empty;

                // Start the coroutine for animating the text
                StartCoroutine(AnimateText());
            }
        }

        // Coroutine for animating the text
        private IEnumerator AnimateText()
        {
            // Wait for the specified start delay before starting the animation
            yield return new WaitForSeconds(startDelay);

            // Iterate through each character in the full text
            for (int i = 0; i < fullText.Length; i++)
            {
                // Update the TextMeshPro text with the substring up to the current character
                textMeshPro.text = fullText.Substring(0, i + 1);

                // Wait for the specified delay between each letter
                yield return new WaitForSeconds(interLetterDelay);
            }
        }
    }
}