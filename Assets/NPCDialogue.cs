using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    private int count = 0;

    public void Interact()
    {
        count++;
        Debug.Log("Interaction successful. Interacted with: " + count);
    }
}
