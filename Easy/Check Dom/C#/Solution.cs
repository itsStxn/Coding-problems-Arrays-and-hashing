using System.Text.RegularExpressions;

namespace Check_Dom;


public class Solution {
    private string TagName(string str) {
        return Regex.Replace(str, @"<|>", "");
    }
    public bool IsTag(string str) {
        str = str.Replace("/", "");
        return  str == "<div>"  ||
                str == "<b>"    ||
                str == "<p>"    ||
                str == "<i>"    ||
                str == "<em>";
    }
    public string OpenTag(string tag) {
        return tag switch {
            "</div>" => "<div>",
            "</b>" => "<b>",
            "</p>" => "<p>",
            "</em>" => "<em>",
            "</i>" => "<i>",
            _ => "",
        };
    }
    public bool IsClosing(string tag) {
        return tag.Contains('/');
    }
    public string CheckDOM(string str) {
        Stack<string> stack = new();
        List<string> error = new();

        var tags = Regex.Matches(str, @"<\/{0,1}\w+>");
        if (IsClosing(tags[0].Value)) return "false";

        foreach (Match match in tags) {
            string tag = match.Value;
            if (!IsTag(tag)) return TagName(tag);
            
            if (IsClosing(tag)) {
                if (stack.TryPop(out string? tagToClose)) {
                    if (OpenTag(tag) != tagToClose) error.Add(tagToClose);
                    if (error.Count > 1) return "false";
                } else return "false";
            } else stack.Push(tag);
        }

        if (error.Count == 1) return TagName(error[0]);
        else if (stack.Count > 0) return "false";

        return "true";
    }
}
