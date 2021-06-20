using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDialogueTrigguer : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<EndManager>().StartDialogue(dialogue);
    }
    


}
