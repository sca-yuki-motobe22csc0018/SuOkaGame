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
    public bool ok;
    public GameObject nextPrefab;
    public static int count=0;
    int num;
    
    // Start is called before the first frame update
    void Start()
    {
        Player= GameObject.Find("Player");
        ok=false;
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        rb.gravityScale = 0;
        coll.isTrigger = true;
        if (transform.position.x != 5)
        {
            set = true;
            fall = true;
            rb.gravityScale = 1;
            coll.isTrigger = false;
            count+=1;
            if (count % 2 == 0)
            {
                Debug.Log("Des");
                Destroy(this.gameObject);
                return;
            }
        }
        else
        {
            set = false;
            fall = false;
        }
        ok=true;
        
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
        if (count == 2)
        {

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ok==true)
        {
            if (collision.gameObject.tag == this.tag)
            {
                Vector3 hitPos = collision.contacts[0].point;
                if (nextPrefab == null)
                {
                    Destroy(this.gameObject);
                    return;
                }
                GameObject Fruits = Instantiate(nextPrefab, hitPos, Quaternion.identity);
                GameManager.gattai=true;
                Destroy(this.gameObject);
            }
        }
    }
}
