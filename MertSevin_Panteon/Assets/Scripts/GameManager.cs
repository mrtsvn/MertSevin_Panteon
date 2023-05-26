using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isDead;
    public GameObject deadPanel;

    public int gold;
    public Text text;

    private string goldKey = "Gold";

    playerCont pCtrl;
    // Start is called before the first frame update

    private void Awake()
    {
        gold = PlayerPrefs.GetInt(goldKey, 0);
    }
    void Start()
    {
        pCtrl = FindObjectOfType<playerCont>();
        isDead = false;
        deadPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == true)
        {
            Dead();
        }

        Canvas();
    }
    public void Canvas()
    {
        text.text = gold.ToString();
    }

    public void Dead()
    {
        deadPanel.SetActive(true);
    }
    public void Restartbutton()
    {

        SaveGold();

        SceneManager.LoadScene("SampleScene");
    }
    public void SaveGold()
    {
        PlayerPrefs.SetInt(goldKey, gold);
        PlayerPrefs.Save();
    }
}
