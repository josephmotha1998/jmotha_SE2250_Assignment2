using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playermovement : MonoBehaviour
{
  
    private Rigidbody rb;
    private int score;

    public float speed;
    public Text ScoreText;


    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = score +value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Score = 0;
        SetScoreText();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item") && other.gameObject.GetComponent<Renderer>().material.color==Color.blue)
        {
            other.gameObject.SetActive(false);
            Score = 1;
            SetScoreText();

        }
        else if (other.gameObject.CompareTag("Item") && other.gameObject.GetComponent<Renderer>().material.color == Color.red)
        {
            other.gameObject.SetActive(false);
            Score =  2;
            SetScoreText();
            ;
        }
        else if (other.gameObject.CompareTag("Item") && other.gameObject.GetComponent<Renderer>().material.color == Color.magenta)
        {
            other.gameObject.SetActive(false);
            Score = 3;
            SetScoreText();

        }
    } 

    void SetScoreText()
    {
        ScoreText.text = "Score: " + Score.ToString();
    }

}
