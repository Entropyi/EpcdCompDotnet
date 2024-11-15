IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Requests] (
    [RequestId] int NOT NULL,
    [FullName] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Age] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NOT NULL,
    [ImageIDs] nvarchar(max) NOT NULL,
    [Comments] nvarchar(max) NULL,
    [PhotoLocation] nvarchar(max) NOT NULL,
    [PhotoPurpose] nvarchar(max) NULL,
    [CreationTime] datetime2 NOT NULL,
    CONSTRAINT [PK_Requests] PRIMARY KEY ([RequestId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240829075717_InitialCreate', N'8.0.8');
GO

COMMIT;
GO

