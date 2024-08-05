namespace Folio.Models {
    public class ProjectModel {
        public string name;
        public string description;
        public string backgroundURL;
        public TagModel[] tags;
        public string projectURL;

        public ProjectModel(string name, string description, string backgroundURL) {
            this.name = name;
            this.description = description;
            this.backgroundURL = backgroundURL;
        }

        public ProjectModel(string name, string description, string backgroundURL, TagModel[] tags, string projectURL) {
            this.name = name;
            this.description = description;
            this.backgroundURL = backgroundURL;
            this.tags = tags;
            this.projectURL = projectURL;
        }
    }
}
