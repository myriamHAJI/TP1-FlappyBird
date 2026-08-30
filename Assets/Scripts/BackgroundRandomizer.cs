using UnityEngine;

public class BackgroundRandomizer : MonoBehaviour
{
    public Sprite dayBackground;
    public Sprite nightBackground;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        int randomBackground = Random.Range(0, 2);

        if (randomBackground == 0)
        {
            spriteRenderer.sprite = dayBackground;
        }
        else
        {
            spriteRenderer.sprite = nightBackground;
        }
    }
}