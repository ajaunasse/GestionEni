CREATE TABLE [dbo].[Session] (
    [IdSession] INT      NOT NULL,
    [dateDebut] DATETIME NOT NULL,
    [dateFin]   DATETIME NOT NULL,
    [formateur] INT      NOT NULL,
    [formation] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([IdSession] ASC),
    CONSTRAINT [FK_Formateur_Personne] FOREIGN KEY ([formateur]) REFERENCES [dbo].[Personne] ([IdPersonne]),
    CONSTRAINT [FK_Formation_Session] FOREIGN KEY ([formation]) REFERENCES [dbo].[Formation] ([IdFormation])
);