using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float x=0;
    [SerializeField] private float InputX = 0.003f;
    [SerializeField] private float MaxX = 3.6f;
    // Start is called before the first frame update
    void Start()
    {
        x=0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(x,0,0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = InputX;
        }else
         if (Input.GetKey(KeyCode.LeftArrow))
         {
            x = -InputX;
         }else
          {
             x=0;
          }
        if (transform.position.x > 3.7f)
        {
            transform.position=new Vector3(-3.6f,3.5f,0);
        }
        if (transform.position.x < -3.7f)
        {
            transform.position = new Vector3(3.6f, 3.5f, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("a");
    }
}
