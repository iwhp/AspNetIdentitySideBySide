-- MIGRATE DATA
UPDATE dbo.AspNetRoles SET NormalizedName = UPPER(Name);
GO
UPDATE dbo.AspNetUsers SET NormalizedEmail = UPPER(Email);
GO
UPDATE dbo.AspNetUsers SET NormalizedUserName = UPPER(UserName);
GO
