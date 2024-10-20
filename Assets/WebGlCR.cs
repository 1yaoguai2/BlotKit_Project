using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 用来优化webgl项目，退出按钮卡死问题
/// </summary>
public class WebGlCR : MonoBehaviour
{
    void Start()
    {
#if UNITY_WEBGL
        gameObject.SetActive(false);
#else
#endif
    }

    void Update()
    {
    }
}