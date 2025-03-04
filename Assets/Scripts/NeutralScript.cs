using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NeutralScript : NpcBehevior
{
    [SerializeField] GameObject textBoxContainer;
    [SerializeField] TextMeshPro textBox_text;
    private void Start()
    {
        creatureType = "Neutral";
    }
    public override void Speak()
    {
        textBoxContainer.SetActive(true);

        textBox_text.text = "I am " + creatureType;
    }

    public override void die()
    {
        Destroy(gameObject);
    }
    public override void Silence()
    {
        textBoxContainer.SetActive(false);
    }
}
