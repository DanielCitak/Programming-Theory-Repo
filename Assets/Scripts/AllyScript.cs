using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AllyScript : NpcBehevior
{
    public Material AllyMat;
    Renderer allyRenderer;
    [SerializeField] GameObject textBoxContainer;
    [SerializeField] TextMeshPro textBox_text;
    private void Start()
    {
        
        
        allyRenderer = GetComponent<Renderer>();
        creatureType = "Ally";
        if(allyRenderer != null)
        {
            allyRenderer.material = AllyMat;

        }
    }
    public override void Speak()
    {
        
        textBoxContainer.SetActive(true);
        
        textBox_text.text = "I am " + creatureType;
        
    }
    public override void Silence()
    {
        textBoxContainer.SetActive(false);
    }

    public override void die()
    {
        Destroy(gameObject);
    }
}
