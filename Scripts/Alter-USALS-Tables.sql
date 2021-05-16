--Add menu type column in DBMenu
ALTER TABLE DBMenu
ADD MENU_TYPE varchar(1);

UPDATE DBMenu
SET MENU_TYPE = 'A'; --A for Accounts Module k menus, S for Security Module k menus 

--Add karnay hai User Module k items 
--INSERT INTO DBMenu
--VALUES (

--Rename Column name in DBUserRights
USE [USALS-2];
GO  
EXEC sp_rename 'DBUserRights.ACCESSTODB_ALLOWED', 'ACCESSTOMENU_ALLOWED', 'COLUMN';  
GO

--Add column "Description" in userLogActivities 
ALTER TABLE UsersLogActivities
ADD LOG_DESCRIPTION nvarchar(MAX);

-- Add column Type in UsersLog
ALTER TABLE UsersLogs
ADD MODULE_TYPE nvarchar(1);


