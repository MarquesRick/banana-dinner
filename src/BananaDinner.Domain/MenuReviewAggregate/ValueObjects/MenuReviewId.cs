using BananaDinner.Domain.Common.Models;

namespace BananaDinner.Domain.MenuReviewAggregate.ValueObjects;
public sealed class MenuReviewId : ValueObject
{
    public Guid Value { get; }

    private MenuReviewId(Guid value)
    {
        Value = value;
    }

    public static MenuReviewId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    private MenuReviewId()
    {
    }
}
