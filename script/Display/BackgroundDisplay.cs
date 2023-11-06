using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundDisplay : MonoBehaviour
{

    SpriteRenderer[] forestChunks;

    public Sprite[] forestSprites;

    public float forestChunksDistance;

    public float forestChunksSpeed;

    public int forestChunkAmount;

    public float forestChunksStartingPosition;

    public int sortingOrder;

    private void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        forestChunks = new SpriteRenderer[forestChunkAmount];
        float position = forestChunksStartingPosition;

        for (int i = 0; i < forestChunkAmount; i++)
        {
            SpriteRenderer newForestChunk = new GameObject("ForestChunk_" + i).AddComponent<SpriteRenderer>();
            newForestChunk.transform.parent = transform;

            newForestChunk.transform.localPosition = new Vector3(position, 0, 0);
            position += forestChunksDistance;
            newForestChunk.sprite = RandomForestSprite();
            newForestChunk.sortingOrder = sortingOrder;

            forestChunks[i] = newForestChunk;
        }
    }

    private void Update()
    {
        MoveForestChunks();
    }

    void MoveForestChunks()
    {
        for (int i = 0; i < forestChunks.Length; i++)
        {
            forestChunks[i].transform.localPosition -= new Vector3(forestChunksSpeed * Time.deltaTime, 0, 0);
        }

        for (int i = 0; i < forestChunks.Length; i++)
        {
            float minPosition = forestChunksStartingPosition - forestChunksDistance;

            if (forestChunks[i].transform.localPosition.x <= minPosition)
            {
                int nextChunk = i - 1;

                if(i == 0)
                {
                    nextChunk = forestChunks.Length - 1;
                }

                forestChunks[i].transform.localPosition = forestChunks[nextChunk].transform.localPosition + new Vector3(forestChunksDistance, 0, 0);
            }
        }
    }

    Sprite RandomForestSprite()
    {
        return forestSprites[Random.Range(0, forestSprites.Length)];
    }
}
