using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public bool set=false;
    public bool fall=false;
    private float y=0;
    [SerializeField]public GameObject Player;
    private Rigidbody2D rb;
    public Collider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        Player= GameObject.Find("Player");
        set=false;
        fall=false;
        rb = GetComponent<Rigidbody2D>();
        coll= GetComponent<Collider2D>();
        rb.gravityScale=0;
        coll.isTrigger=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (set == true&&fall==false)
        {
            this.transform.position = Player.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (set == false)
            {
                set=true;
            }
            else
            {
                fall=true;
                rb.gravityScale = 1;
                coll.isTrigger =false;
            }
        }
    }
}
