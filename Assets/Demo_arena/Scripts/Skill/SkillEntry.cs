using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Skill
{
    public class SkillEntry
    {
        private int m_id;
        private string name;
        public int Id
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}