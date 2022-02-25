using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Text nameObject;
    public Text dialogueObject;
    public Animator animator;

    public Text choiseA;
    public Text choiseB;
    public Text choiseC;
    public Text choiseD;


    private Queue<string> currentDialog;
    private Queue<string> currentChoises;


    DialogueTrigger DialogueTrigger;

    void Start()
    {
        currentDialog = new Queue<string>();
        currentChoises = new Queue<string>();
    }

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
            DisplayNext();
    }

    public void StartDialogue(Dialogue dialogue, DialogueTrigger trigger)
    {
       
       animator.SetBool("IsOpen", true);
        nameObject.text = dialogue.name;
        currentDialog.Clear();
        currentChoises.Clear();

        DialogueTrigger = trigger;

        foreach(string sentence in dialogue.Conversation[dialogue.converstationPosition].sentences)
        {
            currentDialog.Enqueue(sentence);

        }

        foreach(string choise in dialogue.choises)
        {
            currentChoises.Enqueue(choise);

        }
        

        DisplayNext();
    }


    public void DisplayNext()
    {
        if(currentDialog.Count == 0)
        {
            EndDialogue();

            if(currentChoises.Count != 0)
                showChoises();

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
        animator.SetBool("IsOpen", false);
        Debug.Log("Finsihed");
    }


    void showChoises()
    {
        GameObject dialogeChoises  = GameObject.FindGameObjectWithTag("DialogueChoises");
        dialogeChoises.transform.GetChild(0).gameObject.SetActive(true);

        

        for(int i= 0; i < currentChoises.Count; i++)
        {
            Debug.Log("i");
            Debug.Log(i );
            dialogeChoises.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.SetActive(true);
           
        }
            
        Debug.Log("Choises count");
        Debug.Log(currentChoises.Count );

        choiseA.text = currentChoises.Dequeue();
        if(currentChoises.Count != 0)
        choiseB.text = currentChoises.Dequeue();
        if(currentChoises.Count != 0)
        choiseC.text = currentChoises.Dequeue();
        if(currentChoises.Count != 0)
        choiseD.text = currentChoises.Dequeue();

    }

    void hideChoises()
    {
        GameObject dialogeChoises  = GameObject.FindGameObjectWithTag("DialogueChoises");
        dialogeChoises.transform.GetChild(0).gameObject.SetActive(false);

        for(int i= 0; i < currentChoises.Count; i++)
        {
            Debug.Log("i");
            Debug.Log(i );
            dialogeChoises.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.SetActive(false);
           
        }
    }



    public void pressedA()
    {
        Debug.Log("A is pressed");
        DialogueTrigger.ChoiseIsSet = true;
        DialogueTrigger.choise = "a";
        hideChoises();

    }
    public void pressedB()
    {
        Debug.Log("B is pressed");
        DialogueTrigger.ChoiseIsSet = true;
        DialogueTrigger.choise = "b";
        hideChoises();
    }
    public void pressedC()
    {
        Debug.Log("C is pressed");
        DialogueTrigger.ChoiseIsSet = true;
        DialogueTrigger.choise = "c";
        hideChoises();
    }
    public void presseD()
    {
        Debug.Log("D is pressed");
        DialogueTrigger.ChoiseIsSet = true;
        DialogueTrigger.choise = "d";
        hideChoises();
    }
}
