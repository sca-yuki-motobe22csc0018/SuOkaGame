using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ScoreText;
    public static bool gattai;
    public GameObject gameover;
    AudioSource audioSource;
    [SerializeField] public AudioClip se;
    [SerializeField] public AudioClip se2;
    [SerializeField] public Button button;
    public int score;
    
    void Start()
    {
        gattai=false;
        audioSource = GetComponent<AudioSource>();
        score=0;
        ScoreText.text = "Score:"+Mathf.Clamp(score, 0, 99999).ToString("D5"); 
        gameover.SetActive(false);
        button.onClick.AddListener(Click);
        Fruit.end = false;
        gameover.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Fruit.end == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int FruitNum = 0;
                FruitNum = Random.Range(1, 6);
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
                FruitNum = 0;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                audioSource.PlayOneShot(se);
            }

            if (gattai == true)
            {
                audioSource.PlayOneShot(se2);
                score += 10;
                ScoreText.text = "Score:" + Mathf.Clamp(score, 0, 99999).ToString("D5");
                gattai = false;
            }
        }
        else if(Fruit.end==true)
        {
            gameover.SetActive(true);
            Time.timeScale=0;
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

    void Click()
    {
        SceneManager.LoadScene("Main");
    }
}
