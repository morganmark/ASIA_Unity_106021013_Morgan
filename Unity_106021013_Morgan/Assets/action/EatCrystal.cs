using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EatCrystal : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        GameEsc();
    }

    public Text textCount;
    public GameObject objEsc;//結束提示
    public int nowCount;//當前數
    public int totalCount=10;
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject);
        if(collision.gameObject.tag == "crystal_17_2")
        {
            Destroy(collision.gameObject);

            nowCount++;
            //nowCount = nowCount + 10;
            textCount.text = "寶石: " + nowCount + " / 10";

            if(nowCount == totalCount)
            {
                finish = true;
                objEsc.SetActive(true);
            }

        }
    }

    public bool finish;
    private void GameEsc()
    {
        if (finish)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
