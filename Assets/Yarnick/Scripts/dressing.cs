using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dressing : MonoBehaviour
{
    public GameObject glasses, head, bow, flowers, drake1,drake2;
    // Start is called before the first frame update
    public int i = 0;
    public int j = 0;
    bool green;
    public 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void volgende()
    {
        if (i == 0)
        {
            head.SetActive(true);
            i++;
        }
        else if (i == 1)
        {
            head.SetActive(false);
            glasses.SetActive(true);
            i++;
        }
       else if (i == 2)
        {
            glasses.SetActive(false);
            bow.SetActive(true);
            i++;
        }
        else if (i == 3)
        {
            bow.SetActive(false);
            flowers.SetActive(true);
            i++;
        }
        else if (i == 4)
        {
            flowers.SetActive(false);
            i = 0;
        }

    }
    public void vorige()
    {
        if (i == 0)
        {
            head.SetActive(false);
            flowers.SetActive(true);
            i= 3;
        }
        else if (i == 1)
        {
            head.SetActive(true);
            glasses.SetActive(false);
            i--;
        }
        else if (i == 2)
        {
            glasses.SetActive(true);
            bow.SetActive(false);
            i--;
        }
        else if (i == 3)
        {
            bow.SetActive(true);
            flowers.SetActive(false);
            i--;
        }
        else if (i == 4)
        {
            flowers.SetActive(true);
            i --; 
        }
    }
    public void volgendec()
    {
        if (green==true)
        {
            drake1.SetActive(true);
            drake2.SetActive(false);
            green = false;
        }else if (green == false)
        {
            drake1.SetActive(false);
            drake2.SetActive(true);
            green = true;
        }
    }
    public void vorigec()
    {
        if (green == true)
        {
            drake1.SetActive(true);
            drake2.SetActive(false);
            green = false;
        }
        else if (green == false)
        {
            drake1.SetActive(false);
            drake2.SetActive(true);
            green = true;
        }
    }
} 
