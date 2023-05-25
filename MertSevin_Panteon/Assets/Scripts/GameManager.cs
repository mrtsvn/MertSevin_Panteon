using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isDead;
    public GameObject deadPanel;

    playerCont pCtrl;
    // Start is called before the first frame update
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
    }

    public void Dead()
    {
        Debug.Log("Ölüm Prosedürü");
        deadPanel.SetActive(true);
    }
    public void Restartbutton()
    {

        //PlayerPrefs.SetInt(goldKey, gold);
        //PlayerPrefs.SetInt(skullKey, killCount);

        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }
}
