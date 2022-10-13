using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;//�����͈͂�x���W�̌��E
    private float spawnRangeZ = 20.0f;//�����͈͂�z���W�̏ꏊ
    private float startDelay = 2.0f;//�������o�n�߂鎞��
    private float spawnInterval = 1.5f;//�����Ԋu

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);//����
        float spawnX = Random.Range(-spawnRangeX, spawnRangeX);//x���W�̓����_��
        Vector3 spawnPos = new Vector3(spawnX, 0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay, spawnInterval);
    }

    void Update()
    {
        
    }
}
