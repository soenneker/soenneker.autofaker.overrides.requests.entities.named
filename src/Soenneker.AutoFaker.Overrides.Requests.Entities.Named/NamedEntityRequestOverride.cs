using Soenneker.Requests.Entities.Named;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.Requests.Entities.Named;

/// <summary>
/// An AutoFaker (AutoBogus) override for the NamedEntityRequest object
/// </summary>
public class NamedEntityRequestOverride : AutoFakerOverride<NamedEntityRequest>
{
    public override bool CanOverride(AutoFakerContext context)
    {
        return context.GenerateType.IsSubclassOf(typeof(NamedEntityRequest));
    }

    public override void Generate(AutoFakerOverrideContext context)
    {
    }
}
