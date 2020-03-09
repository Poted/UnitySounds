using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class footsteps : MonoBehaviour
{
    public AudioSource footstep;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        bool btnClicked = Input.GetKeyDown(KeyCode.W) ||
                          Input.GetKeyDown(KeyCode.S) ||
                          Input.GetKeyDown(KeyCode.A) ||
                          Input.GetKeyDown(KeyCode.D) ||
                          Input.GetKeyDown(KeyCode.UpArrow) ||
                          Input.GetKeyDown(KeyCode.RightArrow) ||
                          Input.GetKeyDown(KeyCode.DownArrow) ||
                          Input.GetKeyDown(KeyCode.LeftArrow);

        bool btnUnClicked = Input.GetKeyUp(KeyCode.W) ||
                          Input.GetKeyUp(KeyCode.S) ||
                          Input.GetKeyUp(KeyCode.A) ||
                          Input.GetKeyUp(KeyCode.D) ||
                          Input.GetKeyUp(KeyCode.UpArrow) ||
                          Input.GetKeyUp(KeyCode.RightArrow) ||
                          Input.GetKeyUp(KeyCode.DownArrow) ||
                          Input.GetKeyUp(KeyCode.LeftArrow);

        if (btnClicked)
            footstep.Play();

        else if (btnUnClicked)
                footstep.Stop();



    }
}
