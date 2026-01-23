using Robust.Shared.Configuration;
namespace Content.Shared._White.CCVar;

[CVarDefs]
public sealed partial class WhiteCVars
{
    public static readonly CVarDef<bool> PremiumActive =
    CVarDef.Create("white.funny_features_enabled", true, CVar.CLIENT | CVar.ARCHIVE);
}