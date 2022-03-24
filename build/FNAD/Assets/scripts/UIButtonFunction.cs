using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonFunction : MonoBehaviour
{
    public Animator camera;
    public bool cameraFlipped;

    // Start is called before the first frame update
    void Start()
    {
        cameraFlipped = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FlipCameraUp()
    {
        if (cameraFlipped == false)
        {
            camera.SetBool("flippedup", true);
        }
        if (cameraFlipped == true)
        {
            cameraFlipped = false;
            camera.SetBool("flippedup", false);
        }
        return;
    }
}
