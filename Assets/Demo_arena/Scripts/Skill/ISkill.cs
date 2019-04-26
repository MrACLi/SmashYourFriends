using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skill
{
    public interface ISkill
    {
        /// <summary>
        /// 技能的初始化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="Obeject">施放技能的发出者</param>
        /// <param name="target">施放技能目标</param>
        void Init<T, U>(T Obeject, U target);

        /// <summary>
        /// 通过判断Player状态判断技能是否可以触发
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        bool IsValid(Player.Player player);

        /// <summary>
        /// 技能释放起手
        /// </summary>
        /// <param name="animator">角色上的animator，修改来控制动作</param>
        /// <returns></returns>
        bool Prepare(Animator animator=null);

        /// <summary>
        /// 技能释放结束
        /// </summary>
        void End();

        /// <summary>
        /// 中断技能
        /// </summary>
        void Interrupt();
    }
}