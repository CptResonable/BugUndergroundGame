using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorUtils {
    public static Vector2 FromToV2(Vector2 from, Vector2 to) {
        return to - from;
    }

    public static Vector3 FromToV3(Vector3 from, Vector3 to) {
        return to - from;
    }
}
