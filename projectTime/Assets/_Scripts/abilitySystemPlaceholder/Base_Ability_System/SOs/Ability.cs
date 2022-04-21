using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Abilities/Base Ability", order = 1)]
public class Ability : ScriptableObject
{
    public AbilityType abilityName;
    public string abilityDescription;
    public Sprite abilityImage;

    public override string ToString()
    {
        string tempStr;
        tempStr = $"Ability Name: {abilityName}" +
            $"\nAbility Description: {abilityDescription}";

        return tempStr;
    }
}
