namespace ORMHandsOn
{
    public class Instructor
    {
        public string Name { get; private set; }
        public string SkillLevel { get; private set; }

        public Instructor(string name, string skillLevel)
        {
            Name = name;
            SkillLevel = skillLevel;
        }
    }
}