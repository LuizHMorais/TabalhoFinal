using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class EndDialogue
{
	public string name;

	[TextArea(1, 10)]
	public string[] sentences;
}
