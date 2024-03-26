namespace Folio.Models {
    public static class AppConst {
        //Colors
        public static string light = "#FFFBF5";

        public static string dark = "#2C1F20";

        public static string color = "#FD4556";
        public static string colorTint = "#FD7884";
        public static string colorShade = "#C93744";
        public static string colorTone = "#CD5f69";

        public static string colorSuperTone = "#7F6265";

        //Anim
        public static string duration = "200ms";

        //Descriptions
        public static string descriptionBOTW =
            "Everything is good in this game (imo), from the gameplay to the art direction. " +
            "I am a big fan of Nintendo's work.";
        public static string descriptionFFXII =
            "Love the combat system, the art direction and the whole game to be honest.";
        public static string descriptionAbzu =
            "Just a super chill and beautiful game. " +
            "Also really liked The Pathless from Giant Squid.";

        public static string descriptionAfterChill =
            "A mix of IRl and VR escape game in collaboration with my university and an assurance compagny.";
        public static string descriptionGenesis =
            "Online TCG developed by Celsius Online.";

        public static string descriptionVersusPunch =
            "Game jam game created in 2019 with some friends of mine.";
        public static string descriptionFemora =
            "Game created during my master degree as the final project to present in front of pros.";
        public static string descriptionKatraBall =
            "Just a small side project to play a bit with physics.";
        public static string descriptionKatraHeroes =
            "Mobil strategy game with a TCG inspired twist. " +
            "Used Player.IO for the online part.";
        public static string descriptionFolio =
            "I wanted to experiment a bit with HTML and CSS (and web dev in general).";

        //About me
        public static string aboutMe =
            "Hi! I'm Alexis, a game and more specificaly Unity programmer from France. " +
            "I graduated from Piktura (France) studying Game development and Game design." +
            "\nHere you can see some of the projects I've had the opportunity to work on, " +
            "and some of the personal-things I've been working on. " +
            "\nSometimes I also make websites, like this one. If you have any questions please feel free to contact me.";

        //Skills
        public static readonly Dictionary<string, TagModel> tags = new Dictionary<string, TagModel>() {
            {"c#", new SkillModel("C#", color, 2) },
            {"html", new SkillModel("HTML", color, 1) },
            {"css", new SkillModel("CSS", color, 1) },
            {"js", new SkillModel("JS", color, 1) },
            {"c++", new SkillModel("C++", color, 1) },
            {"unity", new SkillModel("Unity", colorTint, 2) },
            {"blazor", new SkillModel("Blazor", colorTint, 2) },
            {"dev", new TagModel("Dev", colorShade) },
            {"ui", new TagModel("UI", colorShade) },
            {"ux", new TagModel("UX", colorShade) },
            {"lead", new TagModel("Lead", colorShade) },
            {"online", new TagModel("Online", colorTone) },
            {"multi", new TagModel("Multi", colorTone) },
            {"3d", new TagModel("3D", colorTone) },
            {"2d", new TagModel("2D", colorTone) },
            {"vr", new TagModel("VR", colorTone) }
        };

        //Others
        public static string placeHolder = "<Place Holder>";
    }
}
