USE [master]
GO
CREATE LOGIN [bernhoeftUser] WITH PASSWORD=N'us3rTeste!', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO
ALTER SERVER ROLE [bulkadmin] ADD MEMBER [bernhoeftUser]
GO
ALTER SERVER ROLE [dbcreator] ADD MEMBER [bernhoeftUser]
GO
ALTER SERVER ROLE [diskadmin] ADD MEMBER [bernhoeftUser]
GO
ALTER SERVER ROLE [processadmin] ADD MEMBER [bernhoeftUser]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [bernhoeftUser]
GO
ALTER SERVER ROLE [serveradmin] ADD MEMBER [bernhoeftUser]
GO
ALTER SERVER ROLE [setupadmin] ADD MEMBER [bernhoeftUser]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [bernhoeftUser]
GO
USE [master]
GO
CREATE USER [bernhoeftUser] FOR LOGIN [bernhoeftUser]
GO
USE [master]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [bernhoeftUser]
GO
USE [master]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [bernhoeftUser]
GO
USE [master]
GO
ALTER ROLE [db_datareader] ADD MEMBER [bernhoeftUser]
GO
USE [master]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [bernhoeftUser]
GO
USE [master]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [bernhoeftUser]
GO
USE [master]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [bernhoeftUser]
GO
USE [master]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [bernhoeftUser]
GO
USE [master]
GO
ALTER ROLE [db_owner] ADD MEMBER [bernhoeftUser]
GO
USE [master]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [bernhoeftUser]
GO
use [model];
GO
use [master];
GO
USE [model]
GO
CREATE USER [bernhoeftUser] FOR LOGIN [bernhoeftUser]
GO
USE [model]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [bernhoeftUser]
GO
USE [model]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [bernhoeftUser]
GO
USE [model]
GO
ALTER ROLE [db_datareader] ADD MEMBER [bernhoeftUser]
GO
USE [model]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [bernhoeftUser]
GO
USE [model]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [bernhoeftUser]
GO
USE [model]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [bernhoeftUser]
GO
USE [model]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [bernhoeftUser]
GO
USE [model]
GO
ALTER ROLE [db_owner] ADD MEMBER [bernhoeftUser]
GO
USE [model]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [bernhoeftUser]
GO
use [msdb];
GO
use [model];
GO
USE [msdb]
GO
CREATE USER [bernhoeftUser] FOR LOGIN [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [DatabaseMailUserRole] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_datareader] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_owner] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_ssisadmin] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_ssisltduser] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [db_ssisoperator] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [dc_admin] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [dc_operator] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [dc_proxy] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [PolicyAdministratorRole] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [ServerGroupAdministratorRole] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [ServerGroupReaderRole] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [SQLAgentOperatorRole] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [SQLAgentReaderRole] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [SQLAgentUserRole] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [TargetServersRole] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [UtilityCMRReader] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [UtilityIMRReader] ADD MEMBER [bernhoeftUser]
GO
USE [msdb]
GO
ALTER ROLE [UtilityIMRWriter] ADD MEMBER [bernhoeftUser]
GO
use [tempdb];
GO
use [msdb];
GO
USE [tempdb]
GO
CREATE USER [bernhoeftUser] FOR LOGIN [bernhoeftUser]
GO
USE [tempdb]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [bernhoeftUser]
GO
USE [tempdb]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [bernhoeftUser]
GO
USE [tempdb]
GO
ALTER ROLE [db_datareader] ADD MEMBER [bernhoeftUser]
GO
USE [tempdb]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [bernhoeftUser]
GO
USE [tempdb]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [bernhoeftUser]
GO
USE [tempdb]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [bernhoeftUser]
GO
USE [tempdb]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [bernhoeftUser]
GO
USE [tempdb]
GO
ALTER ROLE [db_owner] ADD MEMBER [bernhoeftUser]
GO
USE [tempdb]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [bernhoeftUser]
GO
use [TesteTecnicoBernhoeft];
GO
use [tempdb];
GO
USE [TesteTecnicoBernhoeft]
GO
CREATE USER [bernhoeftUser] FOR LOGIN [bernhoeftUser]
GO
USE [TesteTecnicoBernhoeft]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [bernhoeftUser]
GO
USE [TesteTecnicoBernhoeft]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [bernhoeftUser]
GO
USE [TesteTecnicoBernhoeft]
GO
ALTER ROLE [db_datareader] ADD MEMBER [bernhoeftUser]
GO
USE [TesteTecnicoBernhoeft]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [bernhoeftUser]
GO
USE [TesteTecnicoBernhoeft]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [bernhoeftUser]
GO
USE [TesteTecnicoBernhoeft]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [bernhoeftUser]
GO
USE [TesteTecnicoBernhoeft]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [bernhoeftUser]
GO
USE [TesteTecnicoBernhoeft]
GO
ALTER ROLE [db_owner] ADD MEMBER [bernhoeftUser]
GO
USE [TesteTecnicoBernhoeft]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [bernhoeftUser]
GO
