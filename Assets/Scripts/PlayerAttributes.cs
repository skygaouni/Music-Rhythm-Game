using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    public PlayerHealth health;
    public PlayerMovement movement;
    public PlayerPainResponse painResponse;

    private void Start()
    {
        health.onTakeDamage += painResponse.HandlePain;
        health.onDeath += Die;
    }

    private void Die(Vector3 position)
    {
        painResponse.HandleDeath();
        movement.StopMoving();
    }
}
