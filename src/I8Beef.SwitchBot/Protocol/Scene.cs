using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol
{
    /// <summary>
    /// Scene.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Scene
    {
        /// <summary>
        /// Scene ID.
        /// </summary>
        [JsonProperty(PropertyName = "sceneId")]
        public string SceneId { get; set; }

        /// <summary>
        /// Scene name.
        /// </summary>
        [JsonProperty(PropertyName = "sceneName")]
        public string SceneName { get; set; }
    }
}
