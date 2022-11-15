using UnityEngine;
using UnityEngine.SceneManagement;

public class InputSystem : MonoBehaviour
{
    [SerializeField] KeyCode keyXPositive;
    [SerializeField] KeyCode keyXNegative;
    [SerializeField] KeyCode keyYPositive;
    [SerializeField] KeyCode keyYNegative;

    private int cartDirection = 0;
    private int polkaDirection = 0;

    public int CartDirection => cartDirection;
    public int PolkaDirection => polkaDirection;

    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        //GetCartDirection();
        //GetPolkaDirection();


        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void GetCartDirection()
    {
        if (Input.GetKey(keyYPositive))
        {
            cartDirection = 1;
        }
        else if (Input.GetKey(keyYNegative))
        {
            cartDirection = -1;
        }
        else
        {
            cartDirection = 0;
        }    
    }

    private void GetPolkaDirection()
    {
        if (Input.GetKey(keyXPositive))
        {
            polkaDirection = 1;
        }
        else if (Input.GetKey(keyXNegative))
        {
            polkaDirection = -1;
        }
        else
        {
            polkaDirection = 0;
        }
    }

    public void SetX(int x)
    {
        cartDirection = x;
    }

    public void SetY(int y)
    {
        polkaDirection = y;
    }    
}
