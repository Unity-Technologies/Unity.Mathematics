namespace Unity.Mathematics
{
    /// <summary>
    /// Used by property drawers when vectors should be post normalized.
    /// </summary>
    public class PostNormalizeAttribute : UnityEngine.PropertyAttribute {}

    /// <summary>
    /// Used by property drawers when vectors should not be normalized.
    /// </summary>
    public class DoNotNormalizeAttribute : UnityEngine.PropertyAttribute {}
}
