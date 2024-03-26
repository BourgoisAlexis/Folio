﻿namespace Folio.Models {
    public struct PageModel {
        public string id;
        public string name;
        public string icon;

        public PageModel(string id, string name, string icon) {
            this.id = id;
            this.name = name;
            this.icon = icon;
        }
    }
}
