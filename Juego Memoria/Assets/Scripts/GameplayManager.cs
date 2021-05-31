using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public Text numberText;
    public SpriteRenderer posSpriteForma;
    public List<Sprite> SpriteCartas;
    //public Button[] CartasBotones;
    Button botonProv;
    int level;
    public GameObject canvasPadre;
    public List<RectTransform> posObjectsInPanel;
    public GameObject panelVictory;
    Cartas newCartasFacil;
    GameObject[] cartasFacil;
    public GameObject posTextoPrincipal;
    public GameObject panelReiniciar;
    List<GameObject> cartasList;
    private void Awake()
    {
        GameManager.instance.SetCompleted(false);
        level = GameManager.instance.GetLevel();
        cartasList = GameManager.instance.GetCartasList();
        RandomCarta();
    }
    public void RandomCarta()
    {
        newCartasFacil = cartasList[0].GetComponent<Cartas>();
        cartasFacil = newCartasFacil.GetCartasFacil();

        for (int i = 0; i < cartasFacil.Length; i++)
        {
            int aleatorio = Random.Range(0, posObjectsInPanel.Count);
            //RectTransform rect = posObjectsInPanel[aleatorio].GetComponent<RectTransform>();
            
            GameObject instanciarCorrecto = Instantiate(cartasFacil[i], posObjectsInPanel[aleatorio].anchoredPosition, Quaternion.identity);
            instanciarCorrecto.transform.SetParent(posObjectsInPanel[aleatorio].transform);
            RectTransform rect = instanciarCorrecto.GetComponent<RectTransform>();
            rect.anchoredPosition = Vector2.zero;
            posObjectsInPanel.RemoveAt(aleatorio);
            botonProv = instanciarCorrecto.gameObject.GetComponent<Button>();
            botonProv.interactable = true;
        }
    }
    public void ChangeSprite()
    {
        int aleatorio = Random.Range(0, SpriteCartas.Count);

        Sprite sprite = SpriteCartas[aleatorio];
        botonProv.image.sprite = sprite;
        SpriteCartas.RemoveAt(aleatorio);
        /*for (int i = 0; i < SpriteCartas.Count; i++)
        {
            botonProv.image.sprite = SpriteCartas[i];
            SpriteCartas.RemoveAt(i);
        }*/
    }
   
    public void MuteMusic()
    {
        MusicManager.instance.MuteMusic();
    }
    public void PlayButton()
    {
        SoundManager.instance.PlaySFX(SoundManager.instance.buttonSound);
    }
    public void ResetGame()
    {
        GameManager.instance.Resume();
        ManagerScene.instance.SetNumberSceneToChange(1);
        TransitionManager.instance.AnimateTransition();
    }
    public void ReturnMenu()
    {
        GameManager.instance.Resume();
        ManagerScene.instance.SetNumberSceneToChange(0);
        TransitionManager.instance.AnimateTransition();
    }
}
