using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public List<GameObject> currentObjList;

    void Update()
    {
        if(Input.GetButtonDown("Confirm") && currentObjList.Count > 0)
        {
            //open the object's action menu
            Debug.Log(currentObjList[currentObjList.Count-1].name + " says hi.");
            //TODO: check on how to make npc's
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered an object.");
        currentObjList.Add(collision.gameObject);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exited an object.");
        currentObjList.Remove(collision.gameObject);
    }
}
