USE [master]
GO

/****** Object:  Database [Twitter]    Script Date: 9/25/2015 5:20:50 PM ******/
CREATE DATABASE [Twitter]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Twitter', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Twitter.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Twitter_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Twitter_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Twitter] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Twitter].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Twitter] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Twitter] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Twitter] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Twitter] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Twitter] SET ARITHABORT OFF 
GO

ALTER DATABASE [Twitter] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Twitter] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Twitter] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Twitter] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Twitter] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Twitter] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Twitter] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Twitter] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Twitter] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Twitter] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Twitter] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Twitter] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Twitter] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Twitter] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Twitter] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Twitter] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Twitter] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Twitter] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Twitter] SET RECOVERY FULL 
GO

ALTER DATABASE [Twitter] SET  MULTI_USER 
GO

ALTER DATABASE [Twitter] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Twitter] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Twitter] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Twitter] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Twitter] SET  READ_WRITE 
GO
