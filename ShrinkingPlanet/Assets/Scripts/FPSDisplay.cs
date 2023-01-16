using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
    public Text fpsLabel;
    private float pollingTime = 1f;
    private float time;
    private int frameCount;

    

    void Start()
    {
        QualitySettings.vSyncCount = 0;
       //Application.targetFrameRate = 30;
        Application.targetFrameRate = Screen.currentResolution.refreshRate;
    }
    

    void Update ()
    {
        if (Application.targetFrameRate < 30)
        {
            Application.targetFrameRate = 30;
        }

        time += Time.deltaTime;

        frameCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            fpsLabel.text = frameRate.ToString() + " FPS";

            time -= pollingTime;
            frameCount = 0;
        }

/*

        
        //int FPS = (int)(1 / Time.unscaledDeltaTime);
       int FPS = Application.targetFrameRate;
       fpsLabel.text = (FPS).ToString();
        // fpsLabel.text = Mathf.Clamp(FPS, 0, 99).ToString();
       // fpsLabel.text = (1 / Time.unscaledDeltaTime).ToString();
        //fpsLabel.text = Mathf.Clamp(fpsCounter.FPS, 0, 99).ToString();
  */
        }
}
