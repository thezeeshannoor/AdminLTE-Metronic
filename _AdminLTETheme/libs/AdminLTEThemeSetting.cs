namespace AdminLTEThemePrac._AdminLTETheme.libs
{
    public class AdminLTEThemeSetting
    {
        public static AdminLTEThemeBase Config { get; set; } = new AdminLTEThemeBase();

        public static void init(IConfiguration configuration)
        {
            Config = configuration.GetSection("Themee").Get<AdminLTEThemeBase>() ?? Config;
        }
    }
}
