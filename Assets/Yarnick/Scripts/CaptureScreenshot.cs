using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureScreenshot : MonoBehaviour
{
   // public int superSize = 2;
   // private int _shotIndex = 0;
    // Start is called before the first frame update
       public void TakeAShot()
    {
        StartCoroutine("CaptureIt");
    }
    IEnumerator CaptureIt()
    {
        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string fileName = "Screenshot" + timeStamp + ".png";
        string pathToSave = fileName;
        ScreenCapture.CaptureScreenshot(pathToSave);
        yield return new WaitForEndOfFrame();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.A))
       // {
      //      ScreenCapture.CaptureScreenshot($"Screenshot{_shotIndex}.png", superSize);
      //      _shotIndex++;
      // }
    }
}
