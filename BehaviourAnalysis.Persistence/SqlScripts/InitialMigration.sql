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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201127215556_InitialMigration')
BEGIN
    CREATE TABLE [Question] (
        [QuestionId] int NOT NULL IDENTITY,
        [QuestionBody] nvarchar(300) NOT NULL,
        CONSTRAINT [PK_Question] PRIMARY KEY ([QuestionId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201127215556_InitialMigration')
BEGIN
    CREATE TABLE [Questionnaire] (
        [QuestionnaireId] int NOT NULL IDENTITY,
        [Nervous] bit NOT NULL,
        [Panic] bit NOT NULL,
        [BreathingRapidly] bit NOT NULL,
        [Sweating] bit NOT NULL,
        [TroublesInConcentration] bit NOT NULL,
        [TroublesInSleeping] bit NOT NULL,
        [TroublesWithWork] bit NOT NULL,
        [Hopeless] bit NOT NULL,
        [Angry] bit NOT NULL,
        [OverReacting] bit NOT NULL,
        [ChangesInEating] bit NOT NULL,
        [SuicidalThoughts] bit NOT NULL,
        [Tired] bit NOT NULL,
        [CloseFriend] bit NOT NULL,
        [SocialMediaAddiction] bit NOT NULL,
        [WeightGain] bit NOT NULL,
        [MaterialPossession] bit NOT NULL,
        [Shy] bit NOT NULL,
        [StressfulMemories] bit NOT NULL,
        [Nightmares] bit NOT NULL,
        [AvoidingPeople] bit NOT NULL,
        [NegativeThoughts] bit NOT NULL,
        [TroublesInFocusing] bit NOT NULL,
        [BlamingYourself] bit NOT NULL,
        CONSTRAINT [PK_Questionnaire] PRIMARY KEY ([QuestionnaireId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201127215556_InitialMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201127215556_InitialMigration', N'5.0.0');
END;
GO

COMMIT;
GO


