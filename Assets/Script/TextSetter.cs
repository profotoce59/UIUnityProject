using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;

public class TextSetter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nom;
    [SerializeField] private TextMeshProUGUI desc;
    [SerializeField] private TextMeshProUGUI dialogue1;
    [SerializeField] private TextMeshProUGUI dialogue2;
    [SerializeField] private DialogueData perso1;
    [SerializeField] private DialogueData perso2;
    [SerializeField] private DialogueData perso3;
    [SerializeField] private DialogueData perso4;
    private DialogueData currenPerso;
    // Start is called before the first frame update
    void Start()
    {
        nom.text = "";
        desc.text = "";
        dialogue1.text = "";
        dialogue2.text = "";
    }

    // Update is called once per frame
    
}
