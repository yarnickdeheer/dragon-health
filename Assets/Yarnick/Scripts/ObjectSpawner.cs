using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectDToSpawn;
    public GameObject objectEToSpawn;
    public GameObject objectdragon;
    public GameObject objectegg;
    private GameObject drag;
    private GameObject eg;
    private PlacementIndicator placementIndicator;
    private Animator anim;
    private int i = 0;
    private int j = 0;
    private bool egg;
    public GameObject ui;
    bool move = false;
    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
        objectEToSpawn = objectegg;
        objectDToSpawn = objectdragon;
        anim = objectDToSpawn.GetComponent<Animator>();
        ui.SetActive(false);
    }

    void Update()
    {
      //  if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
      //  {
           // dragonpos();
       // }

        if (move ==true)
        {
            drag.gameObject.transform.position = Vector3.MoveTowards(drag.gameObject.transform.position, placementIndicator.transform.position, 0.1f);
            //drag.gameObject.transform.position = placementIndicator.transform.position;
            drag.gameObject.transform.rotation = placementIndicator.transform.rotation;
            if (drag.gameObject.transform.position == placementIndicator.transform.position)
            {
                move = false;
            }
        }
    }

    public void Activate() {

        GameObject obj = Instantiate(objectEToSpawn,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    } 
    public void dragonpos(){
       if(i == 0 && egg== false)
        {
            GameObject obj = Instantiate(objectDToSpawn,
            placementIndicator.transform.position, placementIndicator.transform.rotation);
            drag = obj;
            anim = drag.GetComponent<Animator>();
            anim.SetBool("start", true);
            i++;
        }
        else if(i != 0 && egg == false)
        {
            move = true;
           
        }
        if (j == 0 && egg == true)
        {
            GameObject obj = Instantiate(objectEToSpawn,
            placementIndicator.transform.position, placementIndicator.transform.rotation);
            eg = obj;
            j++;
        }
        else if(j != 0 && egg == true)
        {
            eg.gameObject.transform.position = placementIndicator.transform.position;
            eg.gameObject.transform.rotation = placementIndicator.transform.rotation;
        }



    }
    public void swap()
    {
        if (egg == false)
        {
            egg = true;
            objectEToSpawn = objectegg;
            ui.SetActive(true);

        }
        else
        {
            egg = false;
            objectDToSpawn = objectdragon;
            ui.SetActive(false);
        }
    }


}
