namespace Shimakaze.Sdk.Text.Csf.Yaml;

/// <summary>
/// YamlConstants.
/// </summary>
internal class YamlConstants
{
    /// <summary>
    /// LanguageList.
    /// </summary>
    public static readonly List<string> LanguageList = new()
    {
        "en_US",
        "en_UK",
        "de",
        "fr",
        "es",
        "it",
        "jp",
        "Jabberwockie",
        "kr",
        "zh",
    };

    /// <summary>
    /// SchemaUrls.
    /// </summary>
    public static class SchemaUrls
    {
        /// <summary>
        /// BASEURL.
        /// </summary>
        public const string BASEURL = "https://shimakazeproject.github.io/Schemas";

        /// <summary>
        /// V1.
        /// </summary>
        public const string V1 = $"{BASEURL}/yaml/csf/v1.yaml";

        /// <summary>
        /// Metadata.
        /// </summary>
        public const string Metadata = $"{BASEURL}/yaml/csf/metadata.yaml";
    }
}
