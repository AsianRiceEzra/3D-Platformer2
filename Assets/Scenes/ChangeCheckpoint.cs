using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheckpoint : MonoBehaviour
{
    public GameObject checkpoint;
    private void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
            Destroy(checkpoint);
        Destroy(gameObject);
    }


}
