using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// interface: �����@�o�Ӥ������H���@�w�n��@�o�Ǥ�k���ݩ�
public interface IDamageable
{
    // get; �u��bconstruct�̭��~��]�w��
    public int currentHealth { get; }
    public int maxHealth { get; }

    public delegate void takeDamageEvent(int Damage);
    public event takeDamageEvent onTakeDamage;

    public delegate void deathEvent(Vector3 position);
    public event deathEvent onDeath;

    public void TakeDamage(int damage);
}
