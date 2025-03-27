using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource; // Assign this in the Inspector
    public AudioClip clickSound; // Assign a sound file in the Inspector

    public void PlayClickSound()
    {
        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound); // Play the click sound
        }
    }
}
