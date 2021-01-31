using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_Shoot : MonoBehaviour
{
    public int shotCount;
    public Text shotDisplay;

    private void Update()
    {
        shotDisplay.text = shotCount.ToString();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            if (Input.GetKeyDown("space"))
            {
                if (shotCount > 0)
                {
                    shotCount--;
                    collision.gameObject.GetComponent<Script_DeleteBlock>().delete();
                }
            }
        }
    }
}
