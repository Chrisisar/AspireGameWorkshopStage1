using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Add platform to the list of platforms where coins can spawn
        GameObject.FindAnyObjectByType<CoinSpawner>().Platforms.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
