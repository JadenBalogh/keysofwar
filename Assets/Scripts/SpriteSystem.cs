using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSystem : MonoBehaviour
{
    [SerializeField] private SpriteSet[] spriteSets;

    public Sprite GetSprite(SpriteType spriteType, int playerId)
    {
        foreach (SpriteSet set in spriteSets)
        {
            if (set.spriteType == spriteType)
            {
                if (playerId > 0)
                {
                    return set.playerSprites[playerId - 1];
                }
                else
                {
                    return set.neutralSprite;
                }
            }
        }
        return null;
    }

    [System.Serializable]
    public class SpriteSet
    {
        public SpriteType spriteType;
        public Sprite neutralSprite;
        public Sprite[] playerSprites;
    }
}
