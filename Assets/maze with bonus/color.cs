using UnityEngine;

public class SetColorOnStart : MonoBehaviour
{
    public Renderer targetRenderer;
    public Color newColor = Color.green;   // <-- your static color

    void Start()
    {
        if (targetRenderer == null)
            targetRenderer = GetComponent<Renderer>();

        targetRenderer.material.color = newColor;
    }
}
