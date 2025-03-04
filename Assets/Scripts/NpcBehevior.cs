using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcBehevior : MonoBehaviour
{
    protected int health;
    protected Material material;
    public Material Material
    {   get;set;}

    public int Health
    {
        get { return health; }
        set { health = value; } 
    }
    protected string creatureType;
    public virtual void Speak()
    {
        Debug.Log("Speak method called");
    }
    public virtual void Silence()
    {
        Debug.Log("Silence method called");
    }

    public virtual void die()
    {
        Debug.Log("die method called");
    }
    private void OnMouseOver()
    {
        Speak();
    }
    private void OnMouseExit()
    {
        Silence();
    }
}
