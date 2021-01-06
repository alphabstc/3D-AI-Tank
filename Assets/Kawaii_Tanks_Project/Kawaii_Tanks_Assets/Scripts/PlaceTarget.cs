using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlaceTarget : MonoBehaviour
{
    public GameObject target;  //获取目标点，注意在面板中赋值
    NavMeshAgent mr;   //声明变量
                       // Use this for initialization
    void Start()
    {
        //获取到自身的NavMeshAgent组件
        mr = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //使用属性将目标点的坐标进行传递
        //mr.destination = target.transform.position;
        //使用方法获取目标点坐标，，和前一行代码作用相同
        mr.SetDestination(target.transform.position);
    }
}