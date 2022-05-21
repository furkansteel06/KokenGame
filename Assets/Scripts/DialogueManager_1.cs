using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager_1 : MonoBehaviour
{
    public Text nameText1;
    public Text dialogueText1;
    public int scene1;

    public Animator animator;

    private Queue<string> sentences1;
    void Start()
    {
        sentences1 = new Queue<string>();
    }

    public void StartDialogue1(Dialogue dialogue1)
    {
        animator.SetBool("IsOpen", true);
        nameText1.text = dialogue1.name;

        sentences1.Clear();

        foreach(string sentence in dialogue1.sentences)
        {
            sentences1.Enqueue(sentence);
        }

        DisplayNextSentence1();
    }

    public void DisplayNextSentence1()
    {
        if(sentences1.Count == 0)
        {
            EndDialogue1();
            return;
        }

        string sentence = sentences1.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence1(sentence));
    }

    IEnumerator TypeSentence1 (string sentence1)
    {
        dialogueText1.text = "";
        foreach(char letter in sentence1.ToCharArray())
        {
            dialogueText1.text += letter;
            yield return null;
        }
    }
    void EndDialogue1()
    {
        animator.SetBool("IsOpen", false);
        SceneManager.LoadScene(scene1);
    }

    public void CancelDialogue1()
    {
        animator.SetBool("IsOpen", false);
    }

}
