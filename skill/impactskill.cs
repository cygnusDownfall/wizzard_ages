using System.Collections;
using UnityEngine;

public static class impactskill
{
    public static IEnumerator delay(int time)
    {
        yield return new WaitForSeconds(time);
    }
}
