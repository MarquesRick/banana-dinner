using BananaDinner.Domain.Common.Models;

namespace BananaDinner.Domain.DinnerAggregate.ValueObjects;

public sealed class ReservationId : ValueObject
{
    public Guid Value { get; }

    private ReservationId(Guid value)
    {
        Value = value;
    }

    public static ReservationId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
