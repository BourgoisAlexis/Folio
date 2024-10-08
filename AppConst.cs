﻿using Folio.Client;

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

        public static string narrowBorder = "2px";
        public static int seniorLevel = 4;

        //Descriptions
        public static string descriptionBOTW =
            "Everything is good in this game (imo), from the gameplay to the art direction. " +
            "I am a big fan of Nintendo's work.";
        public static string descriptionFFXII =
            "Love the combat system, the art direction and the whole game to be honest.";
        public static string descriptionAbzu =
            "Just a super chill and beautiful game. " +
            "Also really liked The Pathless from Giant Squid.";

        public static string descriptionGenesis =
            "Online TCG developed by Celsius Online.";
        public static string descriptionAfterChill =
            "A mix of IRl and VR escape game in collaboration with my university and an assurance compagny.";
        public static string descriptionGrandsMigrateurs =
            "A serious game made to advertise kids about ecology in collaboration with l’éducation nationale.";


        public static string descriptionVersusPunch =
            "Game jam game created in 2019 with some friends of mine.";
        public static string descriptionFemora =
            "Game created during my master degree as the final project to present in front of pros.";
        public static string descriptionKatraBall =
            "Just a small side project to play a bit with physics.";
        public static string descriptionTurboSuperJump =
            "A quick side project of mobile game created in 2 days.";
        public static string descriptionKatraHeroes =
            "Mobile strategy game with a TCG inspired twist. " +
            "Used Player.IO for the online part.";
        public static string descriptionFolio =
            "I wanted to experiment a bit with HTML and CSS (and web dev in general).";
        public static string descriptionCountries =
            "Game created is solo in about 2 weeks using Unity, PlayerIO and Wikidata.";

        public static string descriptionSpotify =
            "Listen on Spotify";

        //About me
        public static string aboutMe =
            "Hi ! I'm Alexis, a game and more specificaly Unity programmer from France. " +
            "I graduated from Piktura (France) studying Game development and Game design." +
            "\n\nI'm (obviously) passionate about video games " +
            "and also really into music and music composition (even though i'm not really good at any of it)" +
            "\nI mainly code for games but I am also currently learning web dev during my spare time." +
            "\n\nHere you can see some of the projects I've had the opportunity to work on, " +
            "and some of the personal-things I've been working on. " +
            "\n\nIf you have any questions please feel free to reach to me. ";

        //Tags
        public static readonly Dictionary<TagEnum, TagModel> tags = new Dictionary<TagEnum, TagModel>() {
            {TagEnum.Csharp, new SkillModel("C#", color, 3) },
            {TagEnum.Python, new SkillModel("Python", color, 2) },
            {TagEnum.HTML, new SkillModel("HTML", color, 1) },
            {TagEnum.CSS, new SkillModel("CSS", color, 2) },
            {TagEnum.JS, new SkillModel("JS", color, 1) },
            {TagEnum.SPARQL, new SkillModel("SPARQL", color, 1) },

            {TagEnum.Unity, new SkillModel("Unity", colorTint, 3) },
            {TagEnum.dotnet, new SkillModel(".NET", colorTint, 2) },
            {TagEnum.Razor, new SkillModel("Razor", colorTint, 1) },

            {TagEnum.UI, new SkillModel("UI", colorShade, 1) },
            {TagEnum.UX, new SkillModel("UX", colorShade, 1) },
            {TagEnum.Lead, new SkillModel("Lead", colorShade, 1) },

            {TagEnum.Online, new TagModel("Online", colorTone) },
            {TagEnum.Multi, new TagModel("Multi", colorTone) },
            {TagEnum.VR, new TagModel("VR", colorTone) },
            {TagEnum.Mobile, new TagModel("Mobile", colorTone) },
            {TagEnum.Gamejam, new TagModel("Gamejam", colorTone) }
        };

        //Others
        public static string placeHolder = "<Place Holder>";
        public static bool mobile = false;

        public static Action OnGetSize;
    }
}
