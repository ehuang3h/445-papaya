using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void Interact()
    {
        Debug.Log("Interaction successful.");
        text.text = ("Interacting with the NPC.");
    }

    public void EndConversation()
    {
        text.text = null;
    }
}
