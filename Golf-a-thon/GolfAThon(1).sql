-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
USE dbSQL1;     -- Get out of the master database
SET NOCOUNT ON; -- Report only errors

-- --------------------------------------------------------------------------------
-- Drop Tables
-- --------------------------------------------------------------------------------
IF OBJECT_ID( 'TGolferEventYearSponsors' )		IS NOT NULL DROP TABLE	TGolferEventYearSponsors
IF OBJECT_ID( 'TGolferEventYears' )				IS NOT NULL DROP TABLE	TGolferEventYears
IF OBJECT_ID( 'TEventYears' )					IS NOT NULL DROP TABLE	TEventYears
IF OBJECT_ID( 'TGolfers' )						IS NOT NULL DROP TABLE	TGolfers
IF OBJECT_ID( 'TGenders' )						IS NOT NULL DROP TABLE	TGenders
IF OBJECT_ID( 'TShirtSizes' )					IS NOT NULL DROP TABLE	TShirtSizes
IF OBJECT_ID( 'TPaymentTypes' )					IS NOT NULL DROP TABLE	TPaymentTypes
IF OBJECT_ID( 'TSponsors' )						IS NOT NULL DROP TABLE	TSponsors
IF OBJECT_ID( 'TSponsorTypes' )					IS NOT NULL DROP TABLE	TSponsorTypes

-- usp 
IF OBJECT_ID( 'uspAddGolfer' )					IS NOT NULL DROP PROCEDURE	uspAddGolfer
IF OBJECT_ID( 'uspAddEventYear' )				IS NOT NULL DROP PROCEDURE	uspAddEventYear 
IF OBJECT_ID( 'uspAddGolferYear' )				IS NOT NULL DROP PROCEDURE	uspAddGolferYear  	
IF OBJECT_ID( 'uspAddSponsor' )					IS NOT NULL DROP PROCEDURE	uspAddSponsor 
IF OBJECT_ID( 'uspAddGolferSponsor' )			IS NOT NULL DROP PROCEDURE	uspAddGolferSponsor  

---- views
IF OBJECT_ID( 'vGolferEvents' )					IS NOT NULL DROP VIEW	vGolferEvents
IF OBJECT_ID( 'vAvailableGolfers' )				IS NOT NULL DROP VIEW	vAvailableGolfers
-- --------------------------------------------------------------------------------
-- Step #1: Create Tables
-- --------------------------------------------------------------------------------
CREATE TABLE TEventYears
(
	 intEventYearID		INTEGER	IDENTITY		NOT NULL
	,intEventYear		INTEGER			NOT NULL
	,CONSTRAINT TEventYears_PK PRIMARY KEY ( intEventYearID	)
)

CREATE TABLE TGenders
(
	 intGenderID		INTEGER			NOT NULL
	,strGenderDesc			VARCHAR(50)		NOT NULL
	,CONSTRAINT TGenders_PK PRIMARY KEY ( intGenderID )
)

CREATE TABLE TShirtSizes
(
	 intShirtSizeID			INTEGER			NOT NULL
	,strShirtSizeDesc		VARCHAR(50)		NOT NULL
	,CONSTRAINT TShirtSizes_PK PRIMARY KEY ( intShirtSizeID )
)

CREATE TABLE TGolfers
(
	 intGolferID		INTEGER IDENTITY			NOT NULL
	,strFirstName		VARCHAR(50)		NOT NULL
	,strLastName		VARCHAR(50)		NOT NULL
	,strStreetAddress	VARCHAR(50)		NOT NULL
	,strCity			VARCHAR(50)		NOT NULL
	,strState			VARCHAR(50)		NOT NULL
	,strZip				VARCHAR(50)		NOT NULL
	,strPhoneNumber		VARCHAR(50)		NOT NULL
	,strEmail			VARCHAR(50)		NOT NULL
	,intShirtSizeID		INTEGER			NOT NULL
	,intGenderID		INTEGER			NOT NULL
	,CONSTRAINT TGolfers_PK PRIMARY KEY ( intGolferID )
)

CREATE TABLE TSponsors
(
	 intSponsorID		INTEGER IDENTITY  NOT NULL
	,strFirstName		VARCHAR(50)		NOT NULL
	,strLastName		VARCHAR(50)		NOT NULL
	,strStreetAddress	VARCHAR(50)		NOT NULL
	,strCity			VARCHAR(50)		NOT NULL
	,strState			VARCHAR(50)		NOT NULL
	,strZip				VARCHAR(50)		NOT NULL
	,strPhoneNumber		VARCHAR(50)		NOT NULL
	,strEmail			VARCHAR(50)		NOT NULL
	,CONSTRAINT TSponsors_PK PRIMARY KEY ( intSponsorID )
)

CREATE TABLE TPaymentTypes
(
	 intPaymentTypeID		INTEGER			NOT NULL
	,strPaymentTypeDesc		VARCHAR(50)		NOT NULL
	,CONSTRAINT TPaymentTypes_PK PRIMARY KEY ( intPaymentTypeID )
)

CREATE TABLE TGolferEventYears
(
	 intGolferEventYearID	INTEGER IDENTITY 		NOT NULL
	,intGolferID			INTEGER			NOT NULL
	,intEventYearID			INTEGER			NOT NULL
	,CONSTRAINT TGolferEventYears_UQ UNIQUE ( intGolferID, intEventYearID )
	,CONSTRAINT TGolferEventYears_PK PRIMARY KEY ( intGolferEventYearID )
)


CREATE TABLE TGolferEventYearSponsors
(
	 intGolferEventYearSponsorID	INTEGER	IDENTITY		NOT NULL
	,intGolferID					INTEGER			NOT NULL
	,intEventYearID					INTEGER			NOT NULL
	,intSponsorID					INTEGER			NOT NULL
	,monPledgeAmount				MONEY			NOT NULL
	,intSponsorTypeID				INTEGER			NOT NULL
	,intPaymentTypeID				INTEGER			NOT NULL
	,blnPaid						BIT				NOT NULL
	,CONSTRAINT TGolferEventYearSponsors_UQ UNIQUE ( intGolferID, intEventYearID, intSponsorID )
	,CONSTRAINT TGolferEventYearSponsors_PK PRIMARY KEY ( intGolferEventYearSponsorID )
)

CREATE TABLE TSponsorTypes
(
	 intSponsorTypeID		INTEGER			NOT NULL
	,strSponsorTypeDesc		VARCHAR(50)		NOT NULL
	,CONSTRAINT TSponsorTypes_PK PRIMARY KEY ( intSponsorTypeID )
)


-- --------------------------------------------------------------------------------
-- Step #2: Identify and Create Foreign Keys
-- --------------------------------------------------------------------------------
--
-- #	Child							Parent						Column(s)
-- -	-----							------						---------
-- 1	TGolfers						TGenders					intGenderID
-- 2	TGolfers						TShirtSizes					intShirtSizeID
-- 3    TGolferEventYears				TGolfers					intGolferID
-- 4	TGolferEventYearSponsors		TGolferEventYears			intGolferID, intEventYearID
-- 5	TGolferEventYears				TEventYears					intEventYearID
-- 6    TGolferEventYearSponsors		TSponsors					intSponsorID
-- 7	TGolferEventYearSponsors		TSponsorTypes				intSponsorTypeID
-- 8	TGolferEventYearSponsors		TPaymentTypes				intPaymentTypeID

-- 1
ALTER TABLE TGolfers ADD CONSTRAINT TGolfers_TGenders_FK
FOREIGN KEY ( intGenderID ) REFERENCES TGenders ( intGenderID )

-- 2
ALTER TABLE TGolfers ADD CONSTRAINT TGolfers_TShirtSizes_FK
FOREIGN KEY ( intShirtSizeID ) REFERENCES TShirtSizes ( intShirtSizeID )

-- 3
ALTER TABLE TGolferEventYears ADD CONSTRAINT TGolferEventYears_TGolfers_FK
FOREIGN KEY ( intGolferID ) REFERENCES TGolfers ( intGolferID )

-- 4
ALTER TABLE TGolferEventYearSponsors ADD CONSTRAINT TGolferEventYearSponsors_TGolferEventYears_FK
FOREIGN KEY ( intGolferID, intEventYearID ) REFERENCES TGolferEventYears ( intGolferID, intEventYearID )

-- 5
ALTER TABLE TGolferEventYears ADD CONSTRAINT TGolferEventYears_TEventYears_FK
FOREIGN KEY ( intEventYearID ) REFERENCES TEventYears ( intEventYearID )

-- 6
ALTER TABLE TGolferEventYearSponsors ADD CONSTRAINT TGolferEventYearSponsors_TSponsors_FK
FOREIGN KEY ( intSponsorID ) REFERENCES TSponsors ( intSponsorID )

-- 7
ALTER TABLE TGolferEventYearSponsors ADD CONSTRAINT TGolferEventYearSponsors_TSponsorTypes_FK
FOREIGN KEY ( intSponsorTypeID ) REFERENCES TSponsorTypes ( intSponsorTypeID )

-- 8
ALTER TABLE TGolferEventYearSponsors ADD CONSTRAINT TGolferEventYearSponsors_TPaymentTypes_FK
FOREIGN KEY ( intPaymentTypeID ) REFERENCES TPaymentTypes ( intPaymentTypeID )

-- --------------------------------------------------------------------------------
-- Step #3: Add data to Gender
-- --------------------------------------------------------------------------------

INSERT INTO TGenders( intGenderID, strGenderDesc)
VALUES		(1, 'Female')
		,(2, 'Male')

---- --------------------------------------------------------------------------------
---- Step #4: Add men's and women's shirt sizes
---- --------------------------------------------------------------------------------

INSERT INTO TShirtSizes( intShirtSizeID, strShirtSizeDesc)
VALUES		(1, 'Mens Small')
		,(2, 'Mens Medium')
		,(3, 'Mens Large')
		,(4, 'Mens XLarge')
		,(5, 'Womens Small')
		,(6, 'Womens Medium')
		,(7, 'Womens Large')
		,(8, 'Womens XLarge')

---- --------------------------------------------------------------------------------
---- Step #5: Add years
---- --------------------------------------------------------------------------------
INSERT INTO TEventYears ( intEventYear )
	VALUES	 (2018)
		,(2019)
		,(2020)

---- --------------------------------------------------------------------------------
---- Step #6: Add sponsor types
---- --------------------------------------------------------------------------------
INSERT INTO TSponsorTypes ( intSponsorTypeID, strSponsorTypeDesc)
	VALUES (1, 'Parent')
		,(2, 'Alumni')
		,(3, 'Friend')
		,(4, 'Business')

---- --------------------------------------------------------------------------------
---- Step #7: Add payment types
---- --------------------------------------------------------------------------------
INSERT INTO TPaymentTypes ( intPaymentTypeID, strPaymentTypeDesc)
	VALUES (1, 'Check')
		,(2, 'Cash')
		,(3, 'Credit Card')
---- --------------------------------------------------------------------------------
---- Step #8: Add sponsors
---- --------------------------------------------------------------------------------

INSERT INTO TSponsors ( strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail )
VALUES	 ( 'Jim', 'Smith', '1979 Wayne Trace Rd.', 'Willow', 'OH', '42368', '5135551212', 'jsmith@yahoo.com' )
		,('Sally', 'Jones', '987 Mills Rd.', 'Cincinnati', 'OH', '45202', '5135551234', 'sjones@yahoo.com' )

---- --------------------------------------------------------------------------------
---- Step #9: Add golfers
---- --------------------------------------------------------------------------------

INSERT INTO TGolfers ( strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail, intShirtSizeID, intGenderID )
VALUES	 ('Bill', 'Goldstein', '156 Main St.', 'Mason', 'OH', '45040', '5135559999', 'bGoldstein@yahoo.com', 1, 2 )
		,('Tara', 'Everett', '3976 Deer Run', 'West Chester', 'OH', '45069', '5135550101', 'teverett@yahoo.com', 6, 1 )

---- --------------------------------------------------------------------------------
---- Step # 10: Add Golfers and sponsors to link them
---- --------------------------------------------------------------------------------

INSERT INTO TGolferEventYears ( intGolferID, intEventYearID)
	VALUES (1, 1)
		,(2, 1)
		,(1, 2)
		,(2, 2)

---- --------------------------------------------------------------------------------
---- Step # 10: Add Golfers and sponsors to link them
---- --------------------------------------------------------------------------------
INSERT INTO TGolferEventYearSponsors ( intGolferID, intEventYearID, intSponsorID, monPledgeAmount, intSponsorTypeID, intPaymentTypeID, blnPaid )
VALUES	 ( 1, 1, 1, 25.00, 1, 1, 1 )
		,( 1, 1, 2, 25.00, 1, 1, 1 )
		

		
-- views 
Go 

-- Shows golfers that are assignned events 
CREATE VIEW vGolferEvents 
AS
SELECT 
TG.intGolferID As GolferID, TE.intEventYearID AS Event_Year,TG.strLastName AS LastName
FROM 
TGolferEventYears AS TGE, TGolfers AS TG, TEventYears AS TE
WHERE TG.intGolferID = TGE.intGolferID AND TE.intEventYearID = TGE.intEventYearID

Go 

-- Shows available golfers
CREATE VIEW vAvailableGolfers 
AS
SELECT 
TG.intGolferID As GolferID, TG.strLastName AS LastName
FROM TGolferEventYears AS TGE, TGolfers AS TG
WHERE TG.intGolferID NOT IN (SELECT intGolferID FROM TGolferEventYears)  

go
-- uspAddGolfer 



-- step 1.3
CREATE PROCEDURE uspAddGolfer
	@intGolferID		INTEGER		OUTPUT
	,@strFirstName		VARCHAR(250)
	,@strLastName		VARCHAR(250)		
	,@strStreetAddress	VARCHAR(250)	
	,@strCity			VARCHAR(250)		
	,@strState			VARCHAR(250)		
	,@strZip			VARCHAR(250)
    ,@strPhoneNumber    VARCHAR(250)
    ,@strEmail          VARCHAR(250)
    ,@intShirtSizeID    VARCHAR(250)
    ,@intGenderID       INTEGER		
AS

SET XACT_ABORT ON
-- Terminate and rollback entire transaction on error

BEGIN TRANSACTION
	SELECT @intGolferID = MAX(intGolferID) + 1 
	FROM TGolfers (TABLOCKX) -- lock the table until end of transaction


	-- INSERT data into the table 
	INSERT INTO TGolfers WITH (TABLOCKX)( strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail, intShirtSizeID, intGenderID )
	VALUES(@strFirstName, @strLastName, @strStreetAddress, @strCity, @strState, @strZip, @strPhoneNumber, @strEmail, @intShirtSizeID, @intGenderID )

	SELECT @intGolferID = MAX(@intGolferID)
	FROM TGolfers

COMMIT TRANSACTION 

 
GO


-- uspAddEventYear 
CREATE PROCEDURE uspAddEventYear
	@intEventYearID		INTEGER		OUTPUT
	,@intEventYear		INTEGER	
	
AS

SET XACT_ABORT ON
-- Terminate and rollback entire transaction on error

BEGIN TRANSACTION
	SELECT @intEventYearID = MAX(intEventYearID) + 1 
	FROM TEventYears (TABLOCKX) -- lock the table until end of transaction

	-- INSERT data into the table 
	INSERT INTO TEventYears WITH (TABLOCKX)( intEventYear)
	VALUES( @intEventYear )

	SELECT @intEventYearID = MAX(@intEventYearID)
	FROM TEventYears

COMMIT TRANSACTION 


GO

-- 

-- uspAddGolferSponsor 

CREATE PROCEDURE uspAddSponsor
	@intSponsorID		INTEGER		OUTPUT
	,@strFirstName		VARCHAR(250) 
	,@strLastName		VARCHAR(250) 
	,@strStreetAddress	VARCHAR(250) 
	,@strCity			VARCHAR(250) 
	,@strState			VARCHAR(250) 
	,@strZip			VARCHAR(250) 
	,@strPhoneNumber	VARCHAR(250)
	,@strEmail			VARCHAR(250)

	
AS

SET XACT_ABORT ON
-- Terminate and rollback entire transaction on error

BEGIN TRANSACTION
	SELECT @intSponsorID = MAX(intSponsorID) + 1 
	FROM TSponsors (TABLOCKX) -- lock the table until end of transaction


	-- INSERT data into the table 
	INSERT INTO TSponsors WITH (TABLOCKX)( strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail )
	VALUES( @strFirstName, @strLastName, @strStreetAddress, @strCity, @strState, @strZip, @strPhoneNumber, @strEmail )

	SELECT @intSponsorID = MAX(@intSponsorID)
	FROM TSponsors

COMMIT TRANSACTION 


GO




-- uspAddGolferYear

CREATE PROCEDURE uspAddGolferYear
	@intGolferEventYearID	INTEGER		OUTPUT -- using identity for this column 
	,@intGolferID			INTEGER	
	,@intEventYearID		INTEGER	
	
AS

SET XACT_ABORT ON
-- Terminate and rollback entire transaction on error

BEGIN TRANSACTION

	-- INSERT data into the table 
	INSERT INTO TGolferEventYears WITH (TABLOCKX)( intGolferID, intEventYearID)
	VALUES( @intGolferID, @intEventYearID )

	--Selects largest pk 
	SELECT @intGolferEventYearID = MAX(@intGolferEventYearID)
	FROM TGolferEventYears

COMMIT TRANSACTION 


GO


-- uspAddGolferYear

CREATE PROCEDURE uspAddGolferSponsor
	@intGolferEventYearSponsorID	INTEGER		OUTPUT -- using identity for this column 
	,@intGolferID			INTEGER	
	,@intEventYearID		INTEGER	
	,@intSponsorID			INTEGER
	,@monPledgeAmount		MONEY
	,@intSponsorTypeID		INTEGER
	,@intPaymentTypeID		INTEGER
	,@blnPaid				BIT
	
AS

SET XACT_ABORT ON
-- Terminate and rollback entire transaction on error

BEGIN TRANSACTION

	-- INSERT data into the table 
	INSERT INTO TGolferEventYearSponsors WITH (TABLOCKX)( intGolferID, intEventYearID, intSponsorID, monPledgeAmount, intSponsorTypeID, intPaymentTypeID, blnPaid )
	VALUES( @intGolferID, @intEventYearID, @intSponsorID, @monPledgeAmount, @intSponsorTypeID, @intPaymentTypeID, @blnPaid )

	--Selects largest pk 
	SELECT @intGolferEventYearSponsorID = MAX(@intGolferEventYearSponsorID)
	FROM TGolferEventYearSponsors

COMMIT TRANSACTION 


GO








































------ usp and views Test
--DECLARE @intEventYearID AS INTEGER
--EXECUTE uspAddGolferYear @intEventYearID OUTPUT, 1, 3
--EXECUTE uspAddGolferYear @intEventYearID OUTPUT, 2, 3


SELECT * FROM TGolferEventYears
SELECT * FROM TEventYears
SELECT * FROM TSponsors
SELECT * FROM TGolferEventYearSponsors

select * from vAvailableGolfers
select * from vGolferEvents


--SELECT TG.intGolferID AS GolferID, TG.strLastName AS LastName
--FROM TGolfers AS TG, TGolferEventYears AS TGE
--WHERE TGE.intEventYearID <> 1 AND TG.intGolferID = TGE.intGolferID

--Delete FROM TGolferEventYearSponsors  Where intEventYearID = 2 Delete FROM TGolferEventYears  Where intEventYearID = 2

--SELECT TG.intGolferID AS GolferID, TG.strLastName AS LastName
--                         FROM TGolfers AS TG, TGolferEventYears AS TGE 
--                         WHERE TGE.intGolferID NOT IN (SELECT TGE.intGolferID FROM TGolferEventYears AS TGE, TGolfers AS TG WHERE TGE.intEventYearID = 3)

-- SELECT
-- TG.intGolferID
-- ,TG.strLastName
--FROM
-- TGolfers AS TG
--WHERE TG.intGolferID NOT IN (SELECT intGolferID FROM TGolferEventYears
-- WHERE intEventYearID = 1) 


-- usp addsponsor test

--DECLARE @intSponsorID AS INTEGER
--EXECUTE uspAddSponsor @intSponsorID OUTPUT, 'Jimbo', 'Smith', '1979 Wayne Trace Rd.', 'Willow', 'OH', '42368', '5135551212', 'jsmith@yahoo.com'

-- usp addGolferSponser
  --DECLARE @intGolferEventYearSponsorID AS INTEGER 
  --EXECUTE uspAddGolferSponsor @intGolferEventYearSponsorID OUTPUT, 2, 1, 2, 33.00, 1, 1, 1

  --SELECT * FROM TGolferEventYearSponsors
  --SELECT * FROM TSponsors



	