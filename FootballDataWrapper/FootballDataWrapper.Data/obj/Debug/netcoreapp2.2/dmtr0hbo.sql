ALTER TABLE [Team] ADD [TeamId] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Player] ADD [PlayerId] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Competition] ADD [CompetitionId] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200105010843_AddSpecificId', N'2.2.6-servicing-10079');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Player]') AND [c].[name] = N'Position');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Player] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Player] ALTER COLUMN [Position] nvarchar(50) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200105012818_positionNullable', N'2.2.6-servicing-10079');

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Player]') AND [c].[name] = N'DateOfBirth');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Player] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Player] ALTER COLUMN [DateOfBirth] datetime2 NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200105013113_dateofbrithNullable', N'2.2.6-servicing-10079');

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Team]') AND [c].[name] = N'Email');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Team] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Team] ALTER COLUMN [Email] nvarchar(75) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200105013338_EmailNullable', N'2.2.6-servicing-10079');

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Team]') AND [c].[name] = N'TLA');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Team] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Team] ALTER COLUMN [TLA] nvarchar(100) NULL;

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Player]') AND [c].[name] = N'Nationality');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Player] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Player] ALTER COLUMN [Nationality] nvarchar(100) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200105013501_FieldsNullable', N'2.2.6-servicing-10079');

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Team]') AND [c].[name] = N'ShortName');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Team] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Team] ALTER COLUMN [ShortName] nvarchar(100) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200105032508_ChangeSizeCode', N'2.2.6-servicing-10079');

GO

