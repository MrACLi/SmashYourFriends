using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
namespace Skill
{
    public class Skill : ISkill
    {
        public void End()
        {
            throw new System.NotImplementedException();
        }

        public void Init<T, U>(T Obeject, U target)
        {
            throw new System.NotImplementedException();
        }

        public void Interrupt()
        {
            throw new System.NotImplementedException();
        }

        public bool IsValid(Player.Player player)
        {
            throw new System.NotImplementedException();
        }

        public bool Prepare(Animator animator = null)
        {
            throw new System.NotImplementedException();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}