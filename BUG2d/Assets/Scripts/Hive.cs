using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hive : MonoBehaviour {
    [SerializeField] private int spawnCount;
    [SerializeField] private bool executeSpawn;

    private void Update() {
        if (executeSpawn) {
            BugManager.i.SpawnBug(transform);
            executeSpawn = false;
        }
    }
}
