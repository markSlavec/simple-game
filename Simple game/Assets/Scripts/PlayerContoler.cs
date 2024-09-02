using UnityEngine;
using TMPro;
using System;

public class PlayerContoler : MonoBehaviour
{

    public float speed = 5f;

    public TextMeshProUGUI scoreText;
   

    public Rigidbody _rb;

    private int score = 0;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _rb.AddForce(new Vector3(h, 1, v) * speed * Time.fixedDeltaTime) ; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CollectiveCube")
        {
            score++;
            Destroy(other.gameObject);

            if (score != 7)
                scoreText.text = "Score: " + score;

            else
                scoreText.text = "You Win";
        }
    }
}
