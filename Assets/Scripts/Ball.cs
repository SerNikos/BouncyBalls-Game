using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // when we tap the ball it gets destroyed
    private void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
        Destroy(gameObject);
    }
}
