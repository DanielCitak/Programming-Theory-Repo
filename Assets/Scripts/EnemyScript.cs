using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyScript : NpcBehevior
{
    public Material EnemyMaterial;
    [SerializeField] GameObject textBoxContainer;
    [SerializeField] TextMeshPro textBox_text;

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            // Assign the material to the Renderer
            renderer.material = EnemyMaterial;
        }
        creatureType = "Enemy";
        Material = EnemyMaterial;
        
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
