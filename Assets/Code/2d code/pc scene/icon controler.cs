using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class iconcontroler : MonoBehaviour
{
    public GameObject iconFile;


    void OnMouseDown()
    {
        iconFile.SetActive(true);
    }
}
