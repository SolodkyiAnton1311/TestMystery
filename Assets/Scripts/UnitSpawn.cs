using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

public class UnitSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _unitPrefub;
    [SerializeField] private Transform parent;
    [SerializeField] private TMP_Text scoreTable;

    private static UnitSpawn _instance;
    public static UnitSpawn Instance => _instance;
    [Inject] private DiContainer _diContainer;

    [Space] [Header("Game Values")] [SerializeField]
    private int _sizeOfGhost;

    private float width;
    private int score;


    private void Awake()
    {
        width = Screen.width / 2;
        _instance = this;
    }

    void Update()
    {
        SpawnUnit();
    }


    public void SpawnUnit()
    {
        if (parent.childCount < _sizeOfGhost)
        {
            float rnd = Random.Range(-width, width) / 200;
            GameObject ghost = _diContainer.InstantiatePrefab(_unitPrefub,
                new Vector2(parent.position.x, parent.position.y),
                Quaternion.identity, parent);
            ghost.transform.position = new Vector2(ghost.transform.position.x + rnd, ghost.transform.position.y);
            ghost.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void AddScore()
    {
        score++;
        scoreTable.text = score.ToString();
    }
}