using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int FruitNum=0;
            FruitNum=Random.Range(1,6);
            Debug.Log(FruitNum);
            if (FruitNum == 1)
            {
                Fruits1();
            }
            if (FruitNum == 2)
            {
                Fruits2();
            }
            if (FruitNum == 3)
            {
                Fruits3();
            }
            if (FruitNum == 4)
            {
                Fruits4();
            }
            if (FruitNum == 5)
            {
                Fruits5();
            }
            FruitNum=0;
        }
    }

    private void Fruits1()
    {
        GameObject Fruits_prefab = Resources.Load<GameObject>("Fruits1");
        GameObject Fruits = Instantiate(Fruits_prefab, new Vector3(5, 0, 0), Quaternion.identity);
        return;
    }
    private void Fruits2()
    {
        GameObject Fruits_prefab = Resources.Load<GameObject>("Fruits2");
        GameObject Fruits = Instantiate(Fruits_prefab, new Vector3(5, 0, 0), Quaternion.identity);
        return;
    }
    private void Fruits3()
    {
        GameObject Fruits_prefab = Resources.Load<GameObject>("Fruits3");
        GameObject Fruits = Instantiate(Fruits_prefab, new Vector3(5, 0, 0), Quaternion.identity);
        return;
    }
    private void Fruits4()
    {
        GameObject Fruits_prefab = Resources.Load<GameObject>("Fruits4");
        GameObject Fruits = Instantiate(Fruits_prefab, new Vector3(5, 0, 0), Quaternion.identity);
        return;
    }
    private void Fruits5()
    {
        GameObject Fruits_prefab = Resources.Load<GameObject>("Fruits5");
        GameObject Fruits = Instantiate(Fruits_prefab, new Vector3(5, 0, 0), Quaternion.identity);
        return;
    }
}
