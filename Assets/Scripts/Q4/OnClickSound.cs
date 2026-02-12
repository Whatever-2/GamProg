using UnityEngine;

public class OnClickSound : MonoBehaviour
{
    public void PlaySound(int soundIndex)
    {
        AudioManager.instance.PlaySFX(soundIndex);
    }
}
