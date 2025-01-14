﻿namespace ShanesCloud.Data.Entities;

public class UserRole
{
    #region Properties

    public RoleId RoleId { get; set; }

    public Role Role { get; set; }

    public UserId UserId { get; set; }

    public User User { get; set; }

    #endregion

    #region Construction

    public UserRole(RoleId roleId, UserId userId)
    {
        RoleId = roleId;
        UserId = userId;
    }

    #endregion
}
