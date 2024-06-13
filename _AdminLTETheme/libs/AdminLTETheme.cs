namespace AdminLTEThemePrac._AdminLTETheme.libs
{
    public class AdminLTETheme:IAdminLTETheme
    {
        public string GetView(string path)
        {
            return $"{AdminLTEThemeSetting.Config.LayoutDir}/{path}";
        }
    }
}
