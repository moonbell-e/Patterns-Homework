using UnityEngine;

public class OrcFactory : EnemyFactory
{
    public override Paladin CreatePaladin(Transform spawnPoint)
    {
        var orcPaladinPrefab = Resources.Load<GameObject>("OrcPaladin");
        var orcPaladinGo = Object.Instantiate(orcPaladinPrefab, spawnPoint.position, Quaternion.identity);
        var orcPaladin = orcPaladinGo.GetComponent<Paladin>();
        return orcPaladin;
    }

    public override Mage CreateMage(Transform spawnPoint)
    {
        var orcMagePrefab = Resources.Load<GameObject>("OrcMage");
        var orcMageGo = Object.Instantiate(orcMagePrefab, spawnPoint.position, Quaternion.identity);
        var orcMage = orcMageGo.GetComponent<Mage>();
        return orcMage;
    }
}
