namespace FamilyActivity
{
#pragma warning disable
    class You
    {
        public string name, gender;
        public int age;

        public You(string name, int age, string gender)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
    }
    class Parents
    {
        public string name, role, occupation;
        public int age;

        public Parents(string name, int age, string role, string occupation)
        {
            this.name = name;
            this.role = role;
            this.age = age;
            this.occupation = occupation;
        }

    }
    class Children
    {
        public string name, gender;
        public int age;

        public Children(string name, int age, string gender)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
    }

}