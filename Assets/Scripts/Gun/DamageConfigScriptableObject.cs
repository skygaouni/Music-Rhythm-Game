using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using static UnityEngine.ParticleSystem;

[CreateAssetMenu(fileName = "Damage Config", menuName = "Guns/Damage Config", order = 1)]
public class DamageConfigScriptableObject : ScriptableObject
{
    public MinMaxCurve damageCurve;

    // ��b Inspector ���Ĥ@���s�W�o�Ӥ���]Component�^�쪫��W�ɡA�|�۰ʩI�s
    private void Reset()
    {
        // mode: Constant�BCurve�BTwoCurves�BTwoConstants
        damageCurve.mode = ParticleSystemCurveMode.Curve;
    }

    public int getDamage(float distance = 0)
    {
        return Mathf.CeilToInt(damageCurve.Evaluate(distance, Random.value));
    }
}
