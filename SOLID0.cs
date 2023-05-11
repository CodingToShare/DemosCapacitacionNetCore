public enum EnemyTypes
{
 Warrior,
 Archer
}

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private EnemyFactory enemyFactory;

    private EnemyTypeSelector enemyTypeSelector;
    private IntervalSpawner intervalSpawner;

    private void Start()
    {
        enemyTypeSelector = new EnemyTypeSelector(); 
        intervalSpawner = new IntervalSpawner(SpawnRandomEnemy);
    }

    private void Update()
    {
        intervalSpawner.Update(Time.deltaTime);
    }

    private void SpawnRandomEnemy()
    {
        var enemyTypeToSpawn = enemyTypeSelector.Select();
        enemyFactory.Create(enemyTypeToSpawn);
    }
}

public class EnemyTypeSelector
{
    public EnemyTypes Select()
    {
        var enemyTypes = (EnemyTypes[]) Enum.GetValues(typeof(EnemyTypes));
        var randomTypeIndex = Random.Range(0, enemyTypes.Length);
        return enemyTypes[randomTypeIndex];
    }
}

public class IntervalSpawner
{
    private readonly Action spawnCallback;
    private          float  timeToNextSpawn;

    public IntervalSpawner(Action spawnCallback)
    {
        this.spawnCallback = spawnCallback;
        CalculateTimeToNextSpawn();
    }

    private void CalculateTimeToNextSpawn()
    {
        timeToNextSpawn = Random.Range(10, 20);
    }

    public void Update(float elapsedTime)
    {
        timeToNextSpawn -= elapsedTime;
        if (timeToNextSpawn > 0)
        {
            return;
        }

        CalculateTimeToNextSpawn();
        spawnCallback?.Invoke();
    }
}

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private GameObject warrior;
    [SerializeField] private GameObject archer;

    private void Start()
    {
        typeToEnemyPrefab = new Dictionary<EnemyTypes, Enemy>(enemyPrefabs.Length);
        foreach (var enemyPrefab in enemyPrefabs)
        {
            typeToEnemyPrefab.Add(enemyPrefab.Type, enemyPrefab);
        }
    }
    
    public GameObject Create(EnemyTypes enemyTypeToSpawn)
    {
        switch (enemyTypeToSpawn)
        {
            case EnemyTypes.Warrior:
                return Instantiate(warrior);
            case EnemyTypes.Archer:
                return Instantiate(archer);
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}



public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyTypes type;
    public EnemyTypes Type => type;

    // Logic
}