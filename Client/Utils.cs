using Folio.Models;
using Microsoft.AspNetCore.Components;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Web;

public static class Utils {

    public static string ConvertFloatToString(float value) {
        return value.ToString(CultureInfo.InvariantCulture);
    }

    public static string FloatToREM(float value) {
        return $"{value.ToString(CultureInfo.InvariantCulture)}rem";
    }

    public static MarkupString ConvertNewLinesToBreaks(string source) {
        return (MarkupString)Regex.Replace(HttpUtility.HtmlEncode(source), "\r?\n|\r", "<br />");
    }

    public static SkillModel SkillFromTag(TagModel tag) {
        if (tag as SkillModel != null)
            return tag as SkillModel;

        return new SkillModel(tag.name, tag.color, 0);
    }

    public static TagModel[] GetTagsFromList(string[] ids) {
        TagModel[] tags = new TagModel[ids.Length];
        for (int i = 0; i < ids.Length; i++) {
            tags[i] = AppConst.tags[ids[i]];
        }

        return tags;
    }
}
