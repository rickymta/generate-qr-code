using System.Text.RegularExpressions;

namespace QRCodeGeneratorPresentation.Common.Helpers;

public class SlugifyRouteTransformer : IOutboundParameterTransformer
{
    public string? TransformOutbound(object? value)
    {
        if (value == null) return null;

        return Regex.Replace(value.ToString()!, "([a-z])([A-Z])", "$1-$2").ToLower();
    }
}
