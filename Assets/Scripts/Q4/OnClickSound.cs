using UnityEngine;

public class OnClickSound : MonoBehaviour
{
    [SerializeField] int soundIndex;

    public void PlaySound()
    {
        AudioManager.instance.PlaySFX(soundIndex);
    }
}
