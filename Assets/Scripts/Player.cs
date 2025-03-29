using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int jumpForce = 10;
    // Update is called once per frame
    public Rigidbody2D rb;

    public string currColor;

    public SpriteRenderer sr;

    public Color pink;
    public Color cyan;
    public Color magenta;
    public Color yellow;
    void Start()
    {
        SetRandomColor();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != currColor)
        {
            
        }

        if (col.tag == "ColorChanger")
        {
            SpriteRenderer sr2 = col.gameObject.GetComponent<SpriteRenderer>();
            sr.color = sr2.color;
            Destroy(col.gameObject);
        }
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                currColor = "Cyan";
                sr.color = cyan;
                break;
            case 1:
                currColor = "Magenta";
                sr.color = magenta;
                break;
            case 2:
                currColor = "Pink";
                sr.color = pink;
                break;
            case 3:
                currColor = "Yellow";
                sr.color = yellow;
                break;
        }
    }
}


    
    