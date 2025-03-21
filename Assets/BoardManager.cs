using UnityEngine;
using UnityEngine.Tilemaps;


public class BoardManager : MonoBehaviour{
    private Tilemap m_Tilemap;

    public int Width;
    public int Height;
    public Tile[] RoadMap;
    public Tile[] GrassMap;
    private Grid m_Grid;
    

    public class CellData{
        public bool Passable;
    }
    private CellData[,] m_BoardData;

    public Vector3 CellToWorld(Vector2Int cellIndex){
        return m_Tilemap.GetCellCenterWorld((Vector3Int)cellIndex);
    }


    // Start is called before the first frame update
    void Start(){
        m_Tilemap = GetComponentInChildren<Tilemap>();
        m_BoardData = new CellData[Width, Height];

        for (int y = 0; y < Height; ++y){ 
            for (int x = 0; x < Width; ++x){
                Tile tile;
                m_BoardData[x, y] = new CellData();
                if (x == 0 || y == 0 || x == Width - 1 || y == Height - 1)
                {
                    tile = GrassMap[Random.Range(0, GrassMap.Length)];
                    m_BoardData[x, y].Passable = false;
                }
                else{
                    tile = RoadMap[Random.Range(0, RoadMap.Length)];
                    m_BoardData[x, y].Passable = true;
                }

                m_Tilemap.SetTile(new Vector3Int(x, y, 0), tile);
            }
        }
    }
}
