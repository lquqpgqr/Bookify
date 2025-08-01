﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

public record BookingReservedDomainEvent(Guid Id) : IDomainEvent;
