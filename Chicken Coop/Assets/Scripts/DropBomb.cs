using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBomb : MonoBehaviour
{

    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("dropBomb");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator dropBomb()
    {
        yield return new WaitForSeconds(Random.Range(5f, 15f));
        for (; ; )
        {
            bomb.transform.position = new Vector2(transform.position.x, transform.position.y);
            Instantiate(bomb);
            yield return new WaitForSeconds(Random.Range(5f, 15f));
        }
    }
}