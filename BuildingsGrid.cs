using UnityEngine;

public class BuildingsGrid : MonoBehaviour
{
    #region Field

    //public Vector2Int GridSize = new Vector2Int(20, 10);
    //private Building[,] _grid;

    private Building _flyingBuilding;
    private Camera _mainCamera;

    [SerializeField] private GlobalDB _GlobalDB;
    [SerializeField] private BackgroundUI _UI;

    #endregion


    #region UnityMethods

    private void Awake()
    {
        //_grid = new Building[GridSize.x, GridSize.y];
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        if (_flyingBuilding != null)
            CreateBuilding();
    }

    #endregion


    #region Methods

    public void StartPlacingBuilding(Building buldingPrefab)
    {
        if (_flyingBuilding != null)
        {
            Destroy(_flyingBuilding.gameObject);
        }

        _flyingBuilding = Instantiate(buldingPrefab);
    }

    private void CreateBuilding()
    {
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

        if (groundPlane.Raycast(ray, out float position))
        {
            Vector3 worldPosition = ray.GetPoint(position);

            int x = Mathf.RoundToInt(worldPosition.x);
            int y = Mathf.RoundToInt(worldPosition.z);

            bool available = true;

            if (x < 0 || x > _GlobalDB.GridSize.x - _flyingBuilding.Size.x) available = false;
            if (y < 0 || y > _GlobalDB.GridSize.y - _flyingBuilding.Size.y) available = false;
            //if (x < 0 || x > GridSize.x - _flyingBuilding.Size.x) available = false;
            //if (y < 0 || y > GridSize.y - _flyingBuilding.Size.y) available = false;

            //_GlobalDB.isEnothRes(0);

            if (!_GlobalDB.isEnothRes(0))
                available = false;

            if (available && IsPlaceTaken(x,y)) available = false;

            _flyingBuilding.transform.position = new Vector3(x, 0, y);
            _flyingBuilding.SetTransparent(available);

            if (available && Input.GetMouseButtonDown(0))
            {
                PlaceFlyingBuilding(x, y);
            }
        }
    }

    private void PlaceFlyingBuilding(int placeX, int placeY)
    {
        for (int x = 0; x < _flyingBuilding.Size.x; x++)
        {
            for (int y = 0; y < _flyingBuilding.Size.y; y++)
            {
                _GlobalDB._grid[placeX + x, placeY + y] = _flyingBuilding;
                //_grid[placeX + x, placeY + y] = _flyingBuilding;

            }
        }
        //добавить ID здания в список BuildList класса GlobalDB
        _GlobalDB.BuildList.Add(_flyingBuilding.ID);
        //вычесть потраченные ресурсы
        _GlobalDB.BuildingCost(_flyingBuilding.ID);
        _UI.Draw();
        _flyingBuilding.SetNormal();
        _flyingBuilding = null;  
    }

    private bool IsPlaceTaken(int placeX, int placeY)
    {
        for (int x = 0; x < _flyingBuilding.Size.x; x++)
        {
            for (int y = 0; y < _flyingBuilding.Size.y; y++)
            {
                if (_GlobalDB._grid[placeX + x, placeY + y] != null)
                //if (_grid[placeX + x, placeY + y] != null)
                return true;
            }
        }

        return false;
    }
    #endregion
}
