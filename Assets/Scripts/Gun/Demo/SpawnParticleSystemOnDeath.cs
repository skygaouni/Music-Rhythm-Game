using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �j��o�Ӥ���Ҧb�� GameObject �@�w�n�� IDamageable �ե�
[RequireComponent(typeof(IDamageable))]
public class SpawnParticleSystemOnDeath : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem deathSystem;

    public IDamageable damageable;


    private void Awake()
    {
        damageable = GetComponent<IDamageable>();    
    }

    // ��o�Ӥ���ҥήɡ]OnEnable�^�A�۰ʭq�\ onDeath �ƥ� -> ���� Damageable_OnDeath()�v�G
    private void OnEnable()
    {
        damageable.onDeath += Damageable_OnDeath;
    }

    private void Damageable_OnDeath(Vector3 position)
    {
        // Quaternion.identity: �S������]�]�N�O�w�]�¦V�^
        Instantiate(deathSystem, position, Quaternion.identity);
    }

}
