using UnityEngine;

[CreateAssetMenu(fileName = "newFood", menuName = "Shop/Food", order = 51)]
public class Food : Good
{
    [SerializeField] private int _calorie;

    public override void ShowInfo()
    {
        Debug.Log($"{Label}, {Description} \n ÷ена - {Price}, —ытость - {_calorie}");
    }
}
