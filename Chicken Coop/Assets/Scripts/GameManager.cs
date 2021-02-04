using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance {get; private set;}
    private int score = 0;
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void IncScore(int ds)
    {
        score += ds;
        scoreText.text = "Score: " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        IncScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
