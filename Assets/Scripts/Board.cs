using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public List<List<GameObject>> Tiles;
    public int NumTiles;
    public const int NumColumns = 3;

    private const float distBetweenTiles = .75f;
    private const float boardStartY = -2f;
    private Dictionary<TileType, GameObject> TilePrefabs;
    private Transform TileParent;

    // Start is called before the first frame update
    void Start()
    {
        LoadTilePrefabs();
        SetupTiles();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetupTiles()
    {
        NumTiles = 30; // Some number of tiles to generate
        int numTilesPerColumn = // The number of tiles in each row.
        Tiles = new List<List<GameObject>>();
        TileParent = this.transform.Find("Tiles");

        // TODO: User for loop to Fill Tiles NumColums(3) empty Lists of type GameObject (List<GameObject>)
        for (/* over each column */)
        {
            // Add empty list to Tiles
        }

        // TODO: Use two for loops to iterate over NumColumns, and numTilesPerColumn, and instantiate a tile at each position.
        for (/* iterate over each column */)
        {
            for (/* iterate over each row */)
            {
                // Use InstantiateTile to create a tile gameObject
                GameObject newTile = InstantiateTile(/* random tile type */, new Vector2Int(x, y));
                Tiles[/* column index */].Add(/* new tile */);
            }
        }
    }

    /// <summary>
    /// Loads the tile prefabs from Resources/Prefabs/{TileName}
    /// </summary>
    private void LoadTilePrefabs()
    {
        TilePrefabs = new Dictionary<TileType, GameObject>();
        foreach (TileType tileType in System.Enum.GetValues(typeof(TileType)))
        {
            TilePrefabs[tileType] = Resources.Load<GameObject>($"Prefabs/{tileType}");
        }
    }

    /// <summary>
    /// Instantiates a tile gameobject at the given grid position.
    /// </summary>
    /// <param name="tileType">The type of tile to instantiate</param>
    /// <param name="gridPosition">The position of the tile in the tileGrid</param>
    private GameObject InstantiateTile(TileType tileType, Vector2Int gridPosition)
    {
        // Convert the given gridPosition into a world space coordinate. 
        // For example gridPosition (0, 0) should be worldPosition (-distBetweenTiles, boardStartY)
        // gridPosition (1, 4) should be (0, boardStartY + 4 * distBetweenTiles)
        Vector2 position = new Vector2(/* ect... */)
        return Instantiate(/* The tile gameobject prefab, pulled from TilePrefabs */, position, new Quaternion(), TileParent);
    }

    /// <summary>
    /// Rolls a random int between 0 and the number of tiles, converts that to an enum and returns it.
    /// </summary>
    /// <returns>A random TileType</returns>
    private TileType RollRandomTile()
    {
        return (TileType)Random.Range(0, TilePrefabs.Count);
    }
}
