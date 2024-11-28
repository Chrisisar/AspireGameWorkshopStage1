using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.FindAnyObjectByType<CoinSpawner>().Platforms.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
