using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public GameManager gameManager;
    public Sprite redPipe;
    public int redPipeScore = 25;

    public float spawnRate = 2f;
    public float minHeight = -0.2f;
    public float maxHeight = 0.6f;

    public float minGap = 1.5f;
    public float maxGap = 2.2f;
    public float gapDecrease = 0.01f;
    public float minimumGap = 1.2f;

    private float timer;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float randomHeight = Random.Range(minHeight, maxHeight);

        float gapReduction =
            Time.timeSinceLevelLoad * gapDecrease;

        float currentMinGap =
            Mathf.Max(minGap - gapReduction, minimumGap);

        float currentMaxGap =
            Mathf.Max(maxGap - gapReduction, minimumGap + 0.2f);

        float randomGap =
            Random.Range(currentMinGap, currentMaxGap);

        Vector3 spawnPosition =
            new Vector3(transform.position.x, randomHeight, 0);

        GameObject newPipe =
            Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        Transform bottomPipe =
            newPipe.transform.Find("BottomPipe");

        Transform topPipe =
            newPipe.transform.Find("TopPipe");

        bottomPipe.localPosition =
            new Vector3(0, -1.7f - randomGap / 2f, 0);

        topPipe.localPosition =
            new Vector3(0, 1.5f + randomGap / 2f, 0);

        if (gameManager.score >= redPipeScore)
        {
            bottomPipe.GetComponent<SpriteRenderer>().sprite = redPipe;
            topPipe.GetComponent<SpriteRenderer>().sprite = redPipe;
        }

        BoxCollider2D scoreCollider =
            newPipe.transform.Find("ScoreZone").GetComponent<BoxCollider2D>();

        scoreCollider.size =
            new Vector2(scoreCollider.size.x, randomGap);
    }
}