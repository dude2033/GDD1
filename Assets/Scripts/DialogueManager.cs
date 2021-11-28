using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Text nameObject;
    public Text dialogueObject;
    private Queue<string> currentDialog;
    void Start()
    {
        currentDialog = new Queue<string>();
        
    }
    public void StartDialogue(Dialogue dialogue)
    {
       
        nameObject.text = dialogue.name;
        currentDialog.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            currentDialog.Enqueue(sentence);

        }

        DisplayNext();
    }


    public void DisplayNext()
    {
        if(currentDialog.Count == 0)
        {
            EndDialogue();
            return;

        }
        

      //dialogueObject.text = currentDialog.Dequeue();
       StopAllCoroutines();
        StartCoroutine(TypeingSentence(currentDialog.Dequeue()));

    }


    IEnumerator TypeingSentence (string sentence) 
    {
        dialogueObject.text = "";

        foreach(char letter in sentence.ToCharArray())
        {
            dialogueObject.text += letter;
             yield return 0;

        }
    }


    void EndDialogue()
    {
        Debug.Log("Finsihed");
    }



}
