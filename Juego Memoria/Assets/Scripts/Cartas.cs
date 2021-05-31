using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cartas : MonoBehaviour
{
    public GameObject[] cartasFacil;
    public AudioClip audioCartas;
    public Text textCartas;
    public Sprite spriteFondo;

    public Cartas(GameObject[] cartasFacil, AudioClip audioCartas, Sprite spriteFondo, Text textCartas)
    {
        this.cartasFacil = cartasFacil;
        this.audioCartas = audioCartas;
        this.textCartas = textCartas;
        this.spriteFondo = spriteFondo;
    }

    //SETTERS
    public void SetCartasFacil(GameObject[] cartasFacil)
    {
        this.cartasFacil = cartasFacil;
    }
    public void SetAudioCartas(AudioClip audioCartas)
    {
        this.audioCartas = audioCartas;
    }
    public void SetTextCartas(Text textCartas)
    {
        this.textCartas = textCartas;
    }
    public void SetSpriteFondo(Sprite spriteFondo)
    {
        this.spriteFondo = spriteFondo;
    }

    //GETTERS
    public GameObject[] GetCartasFacil()
    {
        return this.cartasFacil;
    }
    public AudioClip GetAudioCartas()
    {
        return this.audioCartas;
    }
    public Text GetTextCartas()
    {
        return this.textCartas;
    }
    public Sprite GetSpriteFondo()
    {
        return this.spriteFondo;
    }
}
