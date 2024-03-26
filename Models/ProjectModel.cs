namespace Folio.Models {
    public struct ProjectModel {
        public string name;
        public string description;
        public TagModel[] tags;
        public string background;

        public ProjectModel(string name, string description, string background) {
            this.name = name;
            this.description = description;
            this.background = background;
        }

        public ProjectModel(string name, string description, string background, TagModel[] tags) {
            this.name = name;
            this.description = description;
            this.background = background;
            this.tags = tags;
        }
    }
}
