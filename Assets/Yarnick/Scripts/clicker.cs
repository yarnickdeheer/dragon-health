using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class clicker : MonoBehaviour
{
    private int i = 0;
    public Text text;
    public GameObject collect,click;
    // Start is called before the first frame update
    void Start()
    {
        text.text = i.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(i >= 40)
        {
            i = 0;
            text.text = i.ToString();
            collect.SetActive(true);
            click.SetActive(false);

        }
    }
    public void counter()
    {
        i++;
        text.text = i.ToString();
    }
}
