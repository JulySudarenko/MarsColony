using UnityEngine;

public class Building : MonoBehaviour
{
    #region Field

    public Renderer MainRenderer;
    public Vector2Int Size = Vector2Int.one;

    #endregion

    public int ID = 0;
    #region UnityMethods

    private void OnDrawGizmos()
    {
        for (int x = 0; x < Size.x; x++)
        {
            for (int y = 0; y < Size.y; y++)
            {
                if ((x + y) % 2 == 0)
                    Gizmos.color = new Color(0.88f, 0f, 1f, 0.3f);
                else
                    Gizmos.color = new Color(1f, 0.68f, 0f, 0.3f);

                Gizmos.DrawCube(transform.position + new Vector3(x, 0, y), new Vector3(1, 1f, 1));
            }
        }
    }

    #endregion


    #region Methods

    private void Start()
    {
        ID = 0;
    }


    public void SetTransparent(bool available)
    {
        if (available)
        {
            MainRenderer.material.color = Color.green;
        }
        else
        {
            MainRenderer.material.color = Color.red;
        }
    }

    public void SetNormal()
    {
        MainRenderer.material.color = Color.white;
    }


    #endregion
}
