using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayEgg : MonoBehaviour
{

    public GameObject egg;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("layEgg");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator layEgg()
    {
        yield return new WaitForSeconds(Random.Range(2f, 5f));
        for (; ; )
        {
            egg.transform.position = new Vector2(transform.position.x, transform.position.y);
            Instantiate(egg);
            yield return new WaitForSeconds(Random.Range(1f, 7f));
        }
    }
}
