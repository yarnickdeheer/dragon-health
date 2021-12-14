using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanagenebt : MonoBehaviour
{
    public GameObject combi, collectie,info,aankleden,collect,clicker, clicker1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void combineer()
    {
        combi.SetActive(true);
    }

    public void coll()
    {
        collectie.SetActive(true);
    }
    public void back()
    {
        combi.SetActive(false);
        collectie.SetActive(false);
    }
    public void backinfo()
    {
        info.SetActive(false);
        collectie.SetActive(true);
    }
    public void dress()
    {
        info.SetActive(false);
        aankleden.SetActive(true);
    }
    public void draginfo()
    {
        info.SetActive(true);
        aankleden.SetActive(false);
    }
    public void collectA()
    {
        combi.SetActive(false);
        collect.SetActive(true);
        clicker.SetActive(false);
    }
    public void collectB()
    {
        combi.SetActive(true);
        collect.SetActive(false);
        clicker.SetActive(false);
    }

    public void clickA()
    {
        clicker.SetActive(true);
        clicker1.SetActive(false);

    }
    public void clickc()
    {
        clicker.SetActive(false);
        clicker1.SetActive(false);

    }
    public void clickB()
    {
        clicker.SetActive(false);
        
    }
}
