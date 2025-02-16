CREATE DATABASE Calculate_History;
GO

USE Calculate_History;
GO

Create TABLE History(
	id int IDENTITY PRIMARY KEY,
	Time DATETIME NOT NULL,
	Num1 FLOAT NOT NULL,
	Num2 FLOAT NOT NULL,
	Result FLOAT NOT NULL
);
GO

CREATE PROCEDURE GetHistory
AS
BEGIN
	SELECT * FROM History;
END;
GO

CREATE PROCEDURE InsertCal
	@Time DATETIME,
	@Num1 float,
	@Num2 float,
	@Result float
AS
BEGIN
	INSERT INTO History(Time,Num1,Num2,Result)
	VALUES (@Time,@Num1,@Num2,@Result);
END;
GO

CREATE PROCEDURE updateHistory
	@id INT,
	@Time DATETIME,
    @Num1 FLOAT,
    @Num2 FLOAT,
    @Result FLOAT,
    @Operator NVARCHAR(1)
AS
BEGIN
	UPDATE History
	SET @Time=Time, Num1=@Num1,Num2=@Num2,Result=@Result,Operator=@Operator
	WHERE id=@id;
END;
GO