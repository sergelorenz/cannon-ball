using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LevelStaticDataScript
{
    public static int level = 20;

    public static void UpdateLevel()
    {
        level += 1;
    }
}
