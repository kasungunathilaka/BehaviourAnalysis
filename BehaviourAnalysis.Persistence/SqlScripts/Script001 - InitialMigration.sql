IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Question] (
    [QuestionId] int NOT NULL IDENTITY,
    [QuestionBody] nvarchar(300) NOT NULL,
    CONSTRAINT [PK_Question] PRIMARY KEY ([QuestionId])
);

GO

CREATE TABLE [Questionnaire] (
    [QuestionnaireId] int NOT NULL IDENTITY,
    [Nervous] int NOT NULL,
    [Panic] int NOT NULL,
    [BreathingRapidly] int NOT NULL,
    [Sweating] int NOT NULL,
    [TroublesInConcentration] int NOT NULL,
    [TroublesInSleeping] int NOT NULL,
    [TroublesWithWork] int NOT NULL,
    [Hopeless] int NOT NULL,
    [Angry] int NOT NULL,
    [OverReacting] int NOT NULL,
    [ChangesInEating] int NOT NULL,
    [SuicidalThoughts] int NOT NULL,
    [Tired] int NOT NULL,
    [CloseFriend] int NOT NULL,
    [SocialMediaAddiction] int NOT NULL,
    [WeightGain] int NOT NULL,
    [MaterialPossession] int NOT NULL,
    [Shy] int NOT NULL,
    [StressfulMemories] int NOT NULL,
    [Nightmares] int NOT NULL,
    [AvoidingPeople] int NOT NULL,
    [NegativeThoughts] int NOT NULL,
    [TroublesInFocusing] int NOT NULL,
    [BlamingYourself] int NOT NULL,
    CONSTRAINT [PK_Questionnaire] PRIMARY KEY ([QuestionnaireId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210512074518_InitialMigration', N'3.1.5');

GO