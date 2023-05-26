using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingWall : MonoBehaviour
{
    public GameObject cam2;

    playerCont pCtrl;
    void Start()
    {
        pCtrl = FindObjectOfType<playerCont>();
        cam2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(pCtrl.stop == true)
        {
            cam2.SetActive(true);
        }
    }
}
