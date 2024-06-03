USE RamenGo 
GO

CREATE PROCEDURE sp_InserePedido
@brothID VARCHAR,
@proteinId VARCHAR
AS

INSERT INTO OrderRamen VALUES (
	@brothID,
	@ProteinId,
	(SELECT 
	(SELECT price FROM Broth B WHERE B.id = @brothID) +
    (SELECT price FROM Protein P WHERE P.id = @proteinId))
)

GO