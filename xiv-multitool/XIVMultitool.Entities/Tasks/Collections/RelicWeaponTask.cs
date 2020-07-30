using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.Collections
{
    public class RelicWeaponTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int DisciplineId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Discipline Discipline { get; set; }
    }

    public interface IRelicWeaponParse
    {
        string Discipline { get; set; }
    }

    public class AnimaWeaponParse : IRelicWeaponParse
    {
        public string Discipline { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string FourthName { get; set; }
    }

    public class EurekanWeaponParse : IRelicWeaponParse
    {
        public string Discipline { get; set; }
        public string AnemosName { get; set; }
        public string ElementalPyrosName { get; set; }
        public string PhyseosName { get; set; }
    }

    public class ZodiacWeaponParse : IRelicWeaponParse
    {
        public string Discipline { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
