namespace Folio.Models {
    public class TagModel {
        public string name;
        public string color;

        public TagModel(string name, string color) {
            this.name = name;
            this.color = color;
        }
    }

    public class SkillModel : TagModel{
        public int level;

        public SkillModel(string name, string color, int level) : base(name, color) {
            this.level = level;
        }
    }
}
