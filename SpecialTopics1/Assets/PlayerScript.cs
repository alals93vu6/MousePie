using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerScript : NetworkBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isLocalPlayer)
        {
            return;
        }

        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            transform.Translate(Input.GetAxisRaw("Horizontal") , 0 , 0);
        }
    }
}
