using UnityEngine;
using TMPro;

public class SimpleDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] lines; // type your lines here
    private int current;
    private bool nearPlayer;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) nearPlayer = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) nearPlayer = false;
    }

    void Update()
    {
        if (nearPlayer && Input.GetKeyDown(KeyCode.Space))
        {
            if (!dialogueText.gameObject.activeSelf)
            {
                dialogueText.gameObject.SetActive(true);
                current = 0;
                dialogueText.text = lines[current];
            }
            else
            {
                current++;
                if (current < lines.Length)
                    dialogueText.text = lines[current];
                else
                    dialogueText.gameObject.SetActive(false);
            }
        }
    }
}