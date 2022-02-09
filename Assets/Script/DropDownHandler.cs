using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropDownHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI TextBox;
    [SerializeField] private GameObject gameObject;
    [SerializeField] private TextMeshProUGUI nom;
    [SerializeField] private TextMeshProUGUI desc;
    [SerializeField] private TextMeshProUGUI dialogue1;
    [SerializeField] private TextMeshProUGUI dialogue2;
    [SerializeField] private DialogueData perso1;
    [SerializeField] private DialogueData perso2;
    [SerializeField] private DialogueData perso3;
    [SerializeField] private DialogueData perso4;
    private DialogueData currenPerso;
    void Start()
    {
        TextBox.text = "Personnages";
        var dropDown = this.transform.GetComponent<Dropdown>();
        dropDown.options.Clear();
        List<string> items = new List<string>();
        items.Add("");
        items.Add("Gandalf Le Blanc");
        items.Add("Gandalf Le Gris");
        items.Add("Theoden");
        items.Add("Roi Sorcier");
        foreach (string item in items)
        {
            dropDown.options.Add(new Dropdown.OptionData() {text = item });
        }
        dropDown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropDown); });
    }

    void DropdownItemSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        TextBox.text = "";
        this.reloadDialogue(dropdown.options[index].text);
    }
    // Update is called once per frame
    private void reloadDialogue(string name)
    {
        switch (name)
        {
            case "Gandalf Le Blanc":
                currenPerso = perso1; 
                break ;
            case "Gandalf Le Gris":
                currenPerso = perso2; 
                break ;
            case "Theoden":
                currenPerso = perso3; 
                break ;
            case "Roi Sorcier":
                currenPerso = perso4; 
                break ;
            default:
                Debug.Log(name);
                return;
                
        }

        nom.text = this.currenPerso.name;
        desc.text = this.currenPerso.description;
        dialogue1.text = this.currenPerso.dialogue1;
        dialogue2.text = this.currenPerso.dialogue2;
    }
}
