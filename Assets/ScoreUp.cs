using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) {
            Score.score+=1;
    // Start is called before the first frame update
    void Start()
    {
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
