using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "new_Weapon", menuName = "Project/Weapon")]
public class Weapon : ScriptableObject
{
    [SerializeField] private int _damageValue = 10;
    
    public int DamageValue { get => _damageValue; set => _damageValue = value; }


    private void Awake()
    {
        Debug.Log("Weapon::Awake");
    }

    private void OnEnable()
    {
        Debug.Log("Weapon::OnEnable");
        _damageValue += 10;
    }

    public void Attack()
    {
        Debug.Log("Attack");
    }
    [ContextMenu("Create Asset From Scriptable Reference")]
    private void CreateAssetFromScriptableReference()
    {
        Weapon newWeaponAsset = ScriptableObject.CreateInstance<Weapon>();
        newWeaponAsset.DamageValue = 35;
        AssetDatabase.CreateAsset(newWeaponAsset, "Assets/Datas/Whip_Weapon.asset");
    }
}
