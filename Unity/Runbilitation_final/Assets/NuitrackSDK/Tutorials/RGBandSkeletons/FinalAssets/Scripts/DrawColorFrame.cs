using UnityEngine;
using UnityEngine.UI;

public class DrawColorFrame : MonoBehaviour
{
    [SerializeField] RawImage background;

    void Start()
    {
        NuitrackManager.onColorUpdate += DrawColor;
    }

    void DrawColor(nuitrack.ColorFrame frame)
    {
        background.texture = frame.ToTexture2D();
    }

    void OnDestroy()    // cambiato da noi per evitare bug 
    {
        NuitrackManager.onColorUpdate -= DrawColor;
    }
}
