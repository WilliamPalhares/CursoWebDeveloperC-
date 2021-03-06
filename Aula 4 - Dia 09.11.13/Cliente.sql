/*
   sábado, 9 de novembro de 201310:54:07
   Usuário: 
   Servidor: William-PC\sqlexpress
   Banco de Dados: master
   Aplicativo: 
*/

/* Para impedir possíveis problemas de perda de dados, analise este script detalhadamente antes de executá-lo fora do contexto do designer de banco de dados.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
EXECUTE sp_rename N'dbo.Cliente.nome', N'Tmp_Nome_2', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Cliente.email', N'Tmp_Email_3', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Cliente.Tmp_Nome_2', N'Nome', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Cliente.Tmp_Email_3', N'Email', 'COLUMN' 
GO
ALTER TABLE dbo.Cliente SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Cliente', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Cliente', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Cliente', 'Object', 'CONTROL') as Contr_Per 