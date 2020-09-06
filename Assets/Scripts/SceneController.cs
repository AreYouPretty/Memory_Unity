using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private SceneController controller;
    [SerializeField] private MemoryCard originalCard;
    [SerializeField] private Sprite[] images;

    private int _id;

    void Start()
    {
        int id = Random.Range(0, images.Length);
        originalCard.SetCard(id, images[id]);
    }

    public int id
    {
        get { return _id; }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
}
