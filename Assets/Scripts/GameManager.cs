using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private int score = 0;
    void Start()
    {
        Text.text = "Score :" + score;
    }
    public void Collectables()
    {
        score+=5;
        Text.text = "Score :" + score;
        if (score==10)
        {
            panels[0].SetActive(true);
            Time.timeScale= 0;
        }
    }
    public void Obstacles()
    {
        score--;
        Text.text = "Score :" + score;
        if (score==-1)
        {
            panels[1].SetActive(true);
            Time.timeScale= 0;
        }
    }
}
