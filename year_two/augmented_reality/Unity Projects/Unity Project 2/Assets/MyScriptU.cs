using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptU : MonoBehaviour
{
    public GameObject ball;
    public GameObject play_button;
    public GameObject stop_button;
    Animator getAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Get Animator
        getAnimator = ball.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play_animation()
    {
        getAnimator.SetTrigger("Bounce");
    }

    public void stop_animation()
    {
        getAnimator.SetTrigger("Stop");
    }

}
