using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaughtSomething : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        if (collision.gameObject.tag == "Egg")
        {
            GameManager.Instance.IncScore(1);
        }
        if (collision.gameObject.tag == "Bomb")
        {
            GameManager.Instance.IncScore(-3);
        }
        
    }
}
