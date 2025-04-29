using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private PlayerGunSelector gunSelector;

    public void FinishReload()
    {
        Debug.Log("Reload");
        gunSelector.activeGun.GunFinishReload();
    }

}
