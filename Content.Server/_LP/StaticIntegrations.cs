using Robust.Shared.Network;
using Content.Shared.Mind;
using Robust.Shared.GameObjects;

namespace Content.Server._LP.Sponsors;

public static class SponsorSimpleManager
{
    public static int GetTier(NetUserId netId)
    {
#if LP
        if (IoCManager.Resolve<SponsorsManager>().TryGetInfo(netId, out var sponsorInfo))
            return sponsorInfo.Tier;
#endif
        return 0;
    }

    public static int GetTier(EntityUid uid)
    {
        if (IoCManager.Resolve<EntityManager>().TryGetComponent(uid, out MindComponent? mind) && mind.UserId is NetUserId userId)
        {
            return GetTier(userId);
        }

        return 0;
    }

    public static string GetUUID(EntityUid uid)
    {
        if (IoCManager.Resolve<EntityManager>().TryGetComponent(uid, out MindComponent? mind) && mind.UserId is NetUserId userId)
        {
            return userId.ToString();
        }

        return string.Empty;
    }

}