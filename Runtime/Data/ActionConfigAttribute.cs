/*
 * 作者：Peter Xiang
 * 联系方式：565067150@qq.com
 * 文档: https://github.com/PxGame
 * 创建时间: 2019/11/4 9:59:33
 */

using System;

#if USE_FIXPOINT
using Single = FPPhysics.Fix64;
using Vector2 = FPPhysics.Vector2;
using Vector3 = FPPhysics.Vector3;
using Quaternion = FPPhysics.Quaternion;
using Matrix4x4 = FPPhysics.Matrix4x4;
using Mathf = FPPhysics.FPUtility;
using ControllerType = System.Object;
#else
using Single = System.Single;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;
using Matrix4x4 = UnityEngine.Matrix4x4;
using Mathf = UnityEngine.Mathf;
using ControllerType = System.Object;
#endif

namespace XMLib.AM
{
    /// <summary>
    /// ActionConfigAttribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ActionConfigAttribute : Attribute
    {
        public Type handlerType { get; protected set; }

        public ActionConfigAttribute(Type handlerType)
        {
            this.handlerType = handlerType;
        }
    }
}