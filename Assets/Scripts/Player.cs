using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.DOJump(new Vector3(transform.position.x + 1f, 1f, transform.position.z), 2f, 1, 0.3f, false);
            
        }
    }
}
