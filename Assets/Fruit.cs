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
    // Start is called before the first frame update
    void Start()
    {
        y=0;
        Player= GameObject.Find("Player");
        set=false;
        fall=false;
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.gravity = new Vector2(0, 10);
        if (set == true&&fall==false)
        {
            this.transform.position = Player.transform.position;
        }else
         if (fall==true)
         {
            y=9.8f;
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
            }
        }
    }
}
