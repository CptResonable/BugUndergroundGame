using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugManager : MonoBehaviour {
    public static BugManager i;
    public Dictionary<uint, Bug> bugs = new Dictionary<uint, Bug>();

    private uint bugIdTicker = 0;

    private void Awake() {
        i = this;
    }

    public void SpawnBug(Transform spawner) {
        GameObject goBug = Instantiate(BugObjects.i.ant, transform);
        goBug.name = "Bug [" + bugIdTicker + "]";
        Bug bug = goBug.GetComponent<Bug>();
        bug.Initialize(spawner.position, spawner.position + spawner.up);
        bugs.Add(bugIdTicker, bug);

        bugIdTicker++;
    }
}
