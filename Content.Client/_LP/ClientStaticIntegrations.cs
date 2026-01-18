namespace Content.Client._LP.Sponsors;

/// <summary>
/// Класс-упрощение для того, чтобы не плодить жуткие строки кода
/// </summary>
public static class SponsorSimpleManager
{
    public static int GetTier()
    {
#if LP
        if (IoCManager.Resolve<SponsorsManager>().TryGetInfo(out var sponsorInfo))
            return sponsorInfo.Tier;
#endif
        return 0;
    }

    public static string GetUUID()
    {
#if LP
        if (IoCManager.Resolve<SponsorsManager>().TryGetInfo(out var sponsorInfo))
            return sponsorInfo.CharacterName;   //Здесь хранится NetUserId, а не имя. опасно менять из-за json
#endif
        return "";
    }
}