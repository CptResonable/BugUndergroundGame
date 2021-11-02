using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BugObjects", menuName = "ScriptableObjects/BugObjects", order = 0)]
public class BugObjects : ScriptableObject {
    public GameObject ant;

    private static BugObjects _i;
    public static BugObjects i {
        get {
            if (_i == null) {
                _i = Resources.Load("BugObjects") as BugObjects;
            }
            return _i;
        }
    }
}
