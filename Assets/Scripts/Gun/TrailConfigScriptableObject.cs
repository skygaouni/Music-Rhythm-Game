using UnityEngine;

[CreateAssetMenu(fileName = "Trail Config", menuName = "Guns/Gun Trail Config", order = 4)]
public class TrailConfigScriptableObject : ScriptableObject
{
    public Material material;
    public AnimationCurve widthCurve; // ����� �e�װʵe���u
    public float duration = 0.5f; // ����s�b���ɶ��]��^
    public float minVertexDistance; // ����y�񤤨��I�������̤p�Z��
    public Gradient Color; // �Mmaterial�t�O?

    public float missDistance = 100f; //�l�u100���ث����
    public float simulationSpeed = 100f; 

}
