using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobScript : MonoBehaviour
{
    public float upforce;           //Upward force of the "flap"
    private bool isdead = false;    //Has the player collided with a wall?

    private Animator anim;           //Reference to the Annimator component 
    private Rigidbody2D rb2d;        //Holds a reference to the Rigidbody component of the bird.

    // Start is called before the first frame update
    void Start()
    {
        //Get reference to the Animator component attached to this GameObject
        anim = GetComponent<Rigidbody2D>();
        //Get and store a reference to the Rigidbody2D attached to this GameObject
        rb2d = GetComponent < Rigidbody2D();
    }

    // Update is called once per frame
    void Update()
    {  
        //Don't allow control if the bird has died 
        if (isdead == false)
        {
            //Look for input to trigger a "flap" 
            if (Input. GetMouseButtonDown(0))
        }
        
    }
}
