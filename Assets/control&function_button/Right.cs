using UnityEngine;
using UnityEngine.EventSystems;

public class Right : MonoBehaviour, /*IPointerDownHandler, IPointerUpHandler,*/ IPointerEnterHandler, IPointerExitHandler
{
    Vector3 moveDirection;
    public Animator animator;
    public GameObject role;
    bool key = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if (key && DB.cango)
        {
            right();
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!DB.backpack_mode)
            key = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        key = false;
    }

    public void right()
    {
        moveDirection.x = 1f;
        animator.GetComponent<Animator>().SetFloat("MoveX", moveDirection.x);
        animator.GetComponent<Animator>().SetFloat("MoveY", moveDirection.y);
        DB.leader_direction = moveDirection;
        role.transform.position += moveDirection * 5 * Time.deltaTime;
        
    }
}
