using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.name == "Player")
        {
            GameState.Score++;
            var coindSpawner = GameObject.FindAnyObjectByType<CoinSpawner>();
            coindSpawner.ShouldSpawnCoin = true;
            Destroy(gameObject);
        }
    }
}
