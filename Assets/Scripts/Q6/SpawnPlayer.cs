using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.Serialization;

public class SpawnPlayer : MonoBehaviour
{
    //this script will instantiate a player prefab based on the button pressed called from a UI button. 
    // //The player prefab will be instantiated at the position of the spawner object based on the number passed onto the button from the array.
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject[] playerPrefabs;
    [SerializeField] GameObject spawnPoint;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnSelectedPlayer(int index)
    {
        if (index >= 0 && index < playerPrefabs.Length)
        {
            Instantiate(playerPrefabs[index], spawnPoint.transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Invalid player index: " + index);
        }
    }

}
