using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public GameObject ScoreTextGameObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTextGameObject.GetComponent<TMP_Text>().text = $"Score: {GameState.Score}";
    }
}
