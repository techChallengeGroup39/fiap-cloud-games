/* ===========================================================
   Script para criar a base de dados FCG (SQL Server)
   - Idempotente (verifica existência antes de criar)
   - Cria schemas
   =========================================================== */

SET NOCOUNT ON;
GO

/* 1) Criar banco se não existir */
IF DB_ID(N'FCG') IS NULL
BEGIN
    PRINT 'Criando base de dados FCG...';
    CREATE DATABASE [FCG]
    -- Você pode ajustar o FILEGROUP, tamanho, log etc conforme necessário
    ;
END
ELSE
BEGIN
    PRINT 'Base de dados FCG já existe.';
END
GO

USE [FCG];
GO

/* 2) Criar schemas */
-- Deleta schemas se existirem e os recria.
IF SCHEMA_ID(N'Promocoes') IS NOT NULL EXEC('DROP SCHEMA Promocoes');
IF SCHEMA_ID(N'Jogo') IS NOT NULL EXEC('DROP SCHEMA Jogo');
IF SCHEMA_ID(N'Biblioteca') IS NOT NULL EXEC('DROP SCHEMA Biblioteca');
IF SCHEMA_ID(N'Usuario') IS NOT NULL EXEC('DROP SCHEMA Usuario');

IF SCHEMA_ID(N'Jogo') IS NULL EXEC('CREATE SCHEMA Jogo'); 
IF SCHEMA_ID(N'Biblioteca') IS NULL EXEC('CREATE SCHEMA Biblioteca'); 
IF SCHEMA_ID(N'Promocoes') IS NULL EXEC('CREATE SCHEMA Promocoes'); 
IF SCHEMA_ID(N'Usuario') IS NULL EXEC('CREATE SCHEMA Usuario'); 