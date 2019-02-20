using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Moves : MonoBehaviour
{
    Vector3 playerPos;
    public Transform destination;
    public Transform hazard;


    // Start is called before the first frame update
    void Start()
    {
        playerPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        { playerPos += transform.forward;  //moves player 
            transform.position = playerPos;
        }

        if (Input.GetKeyDown(KeyCode.S))
        { playerPos -= transform.forward;
            transform.position = playerPos;
        }

        if (Input.GetKeyDown(KeyCode.A))
        { playerPos -= transform.right;
            transform.position = playerPos;
        }

        if (Input.GetKeyDown(KeyCode.D))
        { playerPos += transform.right;
            transform.position = playerPos;
        }

        if (playerPos.x == hazard.position.x &&
        playerPos.y == hazard.position.y) 
            { playerPos -= transform.up;
        }

        transform.position = playerPos;

    }
    
    }

