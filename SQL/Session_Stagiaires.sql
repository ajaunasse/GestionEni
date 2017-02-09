CREATE TABLE [dbo].[Session_Stagiaires] (
    [IdSession]   INT NOT NULL,
    [IdStagiaire] INT NOT NULL,
    CONSTRAINT [PK] PRIMARY KEY NONCLUSTERED ([IdStagiaire] ASC, [IdSession] ASC),
    CONSTRAINT [FK_Session] FOREIGN KEY ([IdSession]) REFERENCES [dbo].[Session] ([IdSession]),
    CONSTRAINT [FK_Stagiaire] FOREIGN KEY ([IdStagiaire]) REFERENCES [dbo].[Personne] ([IdPersonne])
);