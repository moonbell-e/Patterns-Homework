using UnityEngine;

public class ElfFactory : EnemyFactory
{
    public override Paladin CreatePaladin(Transform spawnPoint)
    {
        var elfPaladinPrefab = Resources.Load<GameObject>("ElfPaladin");
        var elfPaladinGo = Object.Instantiate(elfPaladinPrefab, spawnPoint.position, Quaternion.identity);
        var elfPaladin = elfPaladinGo.GetComponent<Paladin>();
        return elfPaladin;
    }

    public override Mage CreateMage(Transform spawnPoint)
    {
        var elfMagePrefab = Resources.Load<GameObject>("ElfMage");
        var elfMageGo = Object.Instantiate(elfMagePrefab, spawnPoint.position, Quaternion.identity);
        var elfMage = elfMageGo.GetComponent<Mage>();
        return elfMage;
    }
}
