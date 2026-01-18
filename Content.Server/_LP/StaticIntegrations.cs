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
        if (IoCManager.Resolve<EntityManager>().TryGetComponent<MindComponent>(uid, out var mindcomp) && mindcomp != null && mindcomp.Session != null)
            return GetTier(mindcomp.Session.UserId);
        return 0;
    }

    public static string GetUUID(EntityUid uid)
    {
        if (IoCManager.Resolve<EntityManager>().TryGetComponent<MindComponent>(uid, out var mindcomp) && mindcomp != null && mindcomp.Session != null)
        {
            var result = mindcomp.Session.UserId;
            return result.ToString();
        }
        return "";
    }
}