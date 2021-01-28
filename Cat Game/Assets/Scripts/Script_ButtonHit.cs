using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ButtonHit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            Debug.Log("Win");
        }
    }
}
