using UnityEngine;

[CreateAssetMenu(fileName = "newEquip", menuName ="Shop/Equip", order = 51)]
public class Equip : Good
{
    [SerializeField] private float _damage;

    public override void ShowInfo()
    {
        Debug.Log($"{Label}, {Description} \n Цена - {Price}, Урон - {_damage}");
    }
}
