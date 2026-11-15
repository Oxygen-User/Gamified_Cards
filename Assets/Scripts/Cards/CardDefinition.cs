
using UnityEngine;


public enum CardType
{
    Body,
    SolutionType,
    Event
}

public enum CardEffectType
{
    None,
    DrawCards
}



[CreateAssetMenu(
    fileName = "NewCard" ,
    menuName = "Card Game/Card Definition"
)]

public class CardDefinition : ScriptableObject
{
    [Header("Basic Information")]
    public string cardID;
    public string cardName;
    public CardType cardType;

    [Header("stats")]
    [Min(0)] public int cost;
    public int power;

    [Header("Tags")]
    public string[] tags;
    public string[] requiredTags;

    [Header("Artwork")]
    public Sprite artwork;


}
