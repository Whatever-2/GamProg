using UnityEngine;

public class PlayEffexts : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] _particleSystem;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        //play all particle systems listed in the array
        foreach (ParticleSystem ps in _particleSystem)
        {
            ps.Play();
        }
        
    }

}
