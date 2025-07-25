﻿using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    public abstract string GenerateToken(User user);
    public abstract RefreshToken GenerateRefreshToken(User user);
}
