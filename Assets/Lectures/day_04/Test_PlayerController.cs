using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_PlayerController : MonoBehaviour
{
    public float minGroundNormalY = 0.65f;
    public float gravityModifier = 1f;
    public float jumpSpeed = 5f;
    public float moveSpeed = 5f;

    protected Vector2 targetVelocity;
    protected bool grounded = false;
    protected Vector2 groundNormal;

    protected Vector2 velocity;
    protected ContactFilter2D contactFilter; //碰撞筛选器
    protected RaycastHit2D[] hitBuffer = new RaycastHit2D[16];
    protected List<RaycastHit2D> hitBufferList = new List<RaycastHit2D>(16);

    protected const float minMoveDistance = 0.001f;
    protected const float shellRadius = 0.01f;

    private void Start()
    {
        //设置碰撞对象检测
        contactFilter.SetLayerMask(Physics2D.GetLayerCollisionMask(gameObject.layer));//使用物理碰撞图层检测碰撞
        //gameObject.layer        ：自己所在的图层
        //GetLayerCollisionMask   ：拿到对象的图层
        //SetLayerMask            ：设置自己的碰撞图层
        //print("Filt layer : " + contactFilter.layerMask.value);
        contactFilter.useTriggers = false;//取消triggers检测
        contactFilter.useLayerMask = true;//使用图层检测
    }

    private void Update()
    {
        targetVelocity = Vector2.zero;

        Vector2 currentMove = targetVelocity;
        currentMove.x = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpSpeed;
            grounded = false;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }

        targetVelocity = currentMove * moveSpeed;
    }

    private void FixedUpdate()
    {
        velocity += gravityModifier * Physics2D.gravity * Time.deltaTime;
        velocity.x = targetVelocity.x;

        //grounded = false;

        //计算水平移动
        Vector2 deltaPosition = velocity * Time.deltaTime;
        Vector2 moveAlongGround = new Vector2(groundNormal.y, groundNormal.x);
        Vector2 move = moveAlongGround * deltaPosition.x;
        Movement(move, false);

        //计算垂直运动
        move = Vector2.up * deltaPosition.y;
        Movement(move, true);
    }

    void Movement(Vector2 move, bool yMovement)
    {
        float distance = move.magnitude; //magnitude : 长度

        if (distance > minMoveDistance)
        {
            //找到碰撞的图层数量
            int count = this.gameObject.GetComponent<Rigidbody2D>().Cast(move, contactFilter, hitBuffer, distance + shellRadius);

            hitBufferList.Clear();

            for (int i = 0; i < count; i++)
            {
                hitBufferList.Add(hitBuffer[i]);
            }

            for (int i = 0; i < hitBufferList.Count; i++)
            {
                //print("in the collotion test");
                //print(hitBufferList[i].collider.name);
                Vector2 currentNormal = hitBufferList[i].normal;
                //print("Point :" + hitBufferList[i].point + " Normal :" + hitBuffer[i].normal);
                Debug.DrawLine(new Vector3(hitBufferList[i].point.x, hitBufferList[i].point.y, 0), new Vector3(hitBufferList[i].normal.x + hitBufferList[i].point.x, hitBufferList[i].normal.y + hitBufferList[i].point.y, 0), Color.red,2.0f);
                //检测坡度倾斜度是否比需要的坡度大
                if (currentNormal.y > minGroundNormalY)
                {
                    grounded = true;
                    if (yMovement)
                    {
                        groundNormal = currentNormal;
                        //print("groundNormal"+groundNormal);
                        currentNormal.x = 0;
                    }
                }


                //计算出投影的长度
                float projection = Vector2.Dot(velocity, currentNormal);

                //抵消速度
                if (projection < 0)
                {
                    //print("velocity : "+velocity);
                    //print("projection : "+projection * currentNormal);
                    velocity = velocity - projection * currentNormal;
                }
                float modifiedDistance = hitBufferList[i].distance - shellRadius;
                //RaycastHit2D.distance : 射线起点到效果点的距离
                //print("distance:" +distance+" modifiedDistance:" + modifiedDistance);

                distance = modifiedDistance < distance ? modifiedDistance : distance;

                //if (modifiedDistance < distance)
                //{
                //    distance = modifiedDistance;
                //}
                //else
                //{
                //    distance = distance;
                //}

            }
        }
        //this.gameObject.GetComponent<Rigidbody2D>().MovePosition(this.gameObject.GetComponent<Rigidbody2D>().position+move);
        this.gameObject.GetComponent<Rigidbody2D>().position = this.gameObject.GetComponent<Rigidbody2D>().position + move.normalized * distance;
        //print("distance:" + distance);
    }
}
