using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Skill
{
    public class SkillTable
    {
        private List<SkillEntry> list;

        SkillTable()
        {
            list = new List<SkillEntry>();
        }

        void add(SkillEntry entry)
        {
            list.Add(entry);
        }

        bool find(int skill_id, string skill_name=null)
        {
            foreach(SkillEntry elem in list){
                if (elem.Id == skill_id)
                    return true;
            }
            return false;
        }
    }
}
