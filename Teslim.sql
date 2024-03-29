USE [master]
GO
/****** Object:  Database [dersProgrami]    Script Date: 7.02.2024 00:49:06 ******/
CREATE DATABASE [dersProgrami]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dersProgrami].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dersProgrami] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dersProgrami] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dersProgrami] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dersProgrami] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dersProgrami] SET ARITHABORT OFF 
GO
ALTER DATABASE [dersProgrami] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dersProgrami] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dersProgrami] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dersProgrami] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dersProgrami] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dersProgrami] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dersProgrami] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dersProgrami] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dersProgrami] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dersProgrami] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dersProgrami] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dersProgrami] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dersProgrami] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dersProgrami] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dersProgrami] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dersProgrami] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dersProgrami] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dersProgrami] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dersProgrami] SET  MULTI_USER 
GO
ALTER DATABASE [dersProgrami] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dersProgrami] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dersProgrami] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dersProgrami] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dersProgrami] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dersProgrami] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dersProgrami] SET QUERY_STORE = OFF
GO
USE [dersProgrami]
GO
/****** Object:  Table [dbo].[bolumataması]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bolumataması](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[bolum] [int] NOT NULL,
	[ders] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bolumler]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bolumler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [bolumadı] UNIQUE NONCLUSTERED 
(
	[ad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dersler]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dersler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[derslikId] [int] NOT NULL,
	[ders] [varchar](100) NOT NULL,
	[kod] [varchar](100) NOT NULL,
	[saat] [varchar](100) NOT NULL,
	[altanalan] [varchar](100) NOT NULL,
	[subelesme] [varchar](100) NOT NULL,
 CONSTRAINT [PK__dersler__3213E83F2F11B28B] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_DersKod] UNIQUE NONCLUSTERED 
(
	[ders] ASC,
	[kod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[derslik]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[derslik](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tur] [varchar](100) NOT NULL,
	[kapasite] [varchar](100) NOT NULL,
	[miktar] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [turs] UNIQUE NONCLUSTERED 
(
	[tur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gunler]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gunler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[day] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Gunler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogretmen]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogretmen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[yetki] [varchar](255) NOT NULL,
	[unvan] [varchar](255) NOT NULL,
	[tc] [varchar](11) NOT NULL,
	[telefon] [varchar](15) NOT NULL,
	[ad] [varchar](255) NOT NULL,
	[sifre] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_tc] UNIQUE NONCLUSTERED 
(
	[tc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_telefon] UNIQUE NONCLUSTERED 
(
	[telefon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogretmenataması]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogretmenataması](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ogretmen] [int] NOT NULL,
	[ders] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [awe] UNIQUE NONCLUSTERED 
(
	[ogretmen] ASC,
	[ders] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgretmenMusaitlik]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgretmenMusaitlik](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ogretmen_id] [int] NOT NULL,
	[gun] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OgretmenMusaitlik] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [asswe] UNIQUE NONCLUSTERED 
(
	[ogretmen_id] ASC,
	[gun] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[program]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[program](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[bolum] [int] NOT NULL,
	[ogretmen] [int] NOT NULL,
	[ders] [int] NOT NULL,
	[derslik] [int] NOT NULL,
	[gun] [int] NOT NULL,
 CONSTRAINT [PK__program__3213E83F74053E59] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zaman]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zaman](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numara] [varchar](100) NOT NULL,
	[tur] [varchar](100) NOT NULL,
	[baslangic] [varchar](100) NOT NULL,
	[bitis] [varchar](100) NOT NULL,
	[Gun] [varchar](100) NULL,
 CONSTRAINT [PK__zaman__3213E83FC6B62D6F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bolumataması]  WITH CHECK ADD FOREIGN KEY([bolum])
REFERENCES [dbo].[bolumler] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[bolumataması]  WITH CHECK ADD  CONSTRAINT [FK__bolumatama__ders__2F10007B] FOREIGN KEY([ders])
REFERENCES [dbo].[dersler] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[bolumataması] CHECK CONSTRAINT [FK__bolumatama__ders__2F10007B]
GO
ALTER TABLE [dbo].[dersler]  WITH CHECK ADD  CONSTRAINT [FK_dersler_derslik] FOREIGN KEY([derslikId])
REFERENCES [dbo].[derslik] ([id])
GO
ALTER TABLE [dbo].[dersler] CHECK CONSTRAINT [FK_dersler_derslik]
GO
ALTER TABLE [dbo].[ogretmenataması]  WITH CHECK ADD FOREIGN KEY([ogretmen])
REFERENCES [dbo].[ogretmen] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ogretmenataması]  WITH CHECK ADD  CONSTRAINT [FK__ogretmenat__ders__2B3F6F97] FOREIGN KEY([ders])
REFERENCES [dbo].[dersler] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ogretmenataması] CHECK CONSTRAINT [FK__ogretmenat__ders__2B3F6F97]
GO
ALTER TABLE [dbo].[bolumler]  WITH CHECK ADD  CONSTRAINT [adBosluk] CHECK  ((len([ad])>=(1)))
GO
ALTER TABLE [dbo].[bolumler] CHECK CONSTRAINT [adBosluk]
GO
ALTER TABLE [dbo].[dersler]  WITH CHECK ADD  CONSTRAINT [CK_altanalan_min_length] CHECK  ((len([altanalan])>=(1)))
GO
ALTER TABLE [dbo].[dersler] CHECK CONSTRAINT [CK_altanalan_min_length]
GO
ALTER TABLE [dbo].[dersler]  WITH CHECK ADD  CONSTRAINT [CK_ders_min_length] CHECK  ((len([ders])>=(1)))
GO
ALTER TABLE [dbo].[dersler] CHECK CONSTRAINT [CK_ders_min_length]
GO
ALTER TABLE [dbo].[dersler]  WITH CHECK ADD  CONSTRAINT [CK_derslikId_min_length] CHECK  ((len(CONVERT([nvarchar](100),[derslikId]))>=(1)))
GO
ALTER TABLE [dbo].[dersler] CHECK CONSTRAINT [CK_derslikId_min_length]
GO
ALTER TABLE [dbo].[dersler]  WITH CHECK ADD  CONSTRAINT [CK_kod_min_length] CHECK  ((len([kod])>=(1)))
GO
ALTER TABLE [dbo].[dersler] CHECK CONSTRAINT [CK_kod_min_length]
GO
ALTER TABLE [dbo].[dersler]  WITH CHECK ADD  CONSTRAINT [CK_saat_min_length] CHECK  ((len([saat])>=(1)))
GO
ALTER TABLE [dbo].[dersler] CHECK CONSTRAINT [CK_saat_min_length]
GO
ALTER TABLE [dbo].[dersler]  WITH CHECK ADD  CONSTRAINT [CK_subelesme_min_length] CHECK  ((len([subelesme])>=(1)))
GO
ALTER TABLE [dbo].[dersler] CHECK CONSTRAINT [CK_subelesme_min_length]
GO
ALTER TABLE [dbo].[derslik]  WITH CHECK ADD  CONSTRAINT [kapasite] CHECK  ((len([kapasite])>=(1)))
GO
ALTER TABLE [dbo].[derslik] CHECK CONSTRAINT [kapasite]
GO
ALTER TABLE [dbo].[derslik]  WITH CHECK ADD  CONSTRAINT [miktar] CHECK  ((len([miktar])>=(1)))
GO
ALTER TABLE [dbo].[derslik] CHECK CONSTRAINT [miktar]
GO
ALTER TABLE [dbo].[derslik]  WITH CHECK ADD  CONSTRAINT [tur] CHECK  ((len([tur])>=(1)))
GO
ALTER TABLE [dbo].[derslik] CHECK CONSTRAINT [tur]
GO
ALTER TABLE [dbo].[ogretmen]  WITH CHECK ADD  CONSTRAINT [CHK_MinChar_Ad] CHECK  ((len([ad])>=(2)))
GO
ALTER TABLE [dbo].[ogretmen] CHECK CONSTRAINT [CHK_MinChar_Ad]
GO
ALTER TABLE [dbo].[ogretmen]  WITH CHECK ADD  CONSTRAINT [CHK_MinChar_Sifre] CHECK  ((len([sifre])>=(2)))
GO
ALTER TABLE [dbo].[ogretmen] CHECK CONSTRAINT [CHK_MinChar_Sifre]
GO
ALTER TABLE [dbo].[ogretmen]  WITH CHECK ADD  CONSTRAINT [CHK_MinChar_Tc] CHECK  ((len([tc])>=(2)))
GO
ALTER TABLE [dbo].[ogretmen] CHECK CONSTRAINT [CHK_MinChar_Tc]
GO
ALTER TABLE [dbo].[ogretmen]  WITH CHECK ADD  CONSTRAINT [CHK_MinChar_Telefon] CHECK  ((len([telefon])>=(2)))
GO
ALTER TABLE [dbo].[ogretmen] CHECK CONSTRAINT [CHK_MinChar_Telefon]
GO
ALTER TABLE [dbo].[ogretmen]  WITH CHECK ADD  CONSTRAINT [CHK_MinChar_Unvan] CHECK  ((len([unvan])>=(2)))
GO
ALTER TABLE [dbo].[ogretmen] CHECK CONSTRAINT [CHK_MinChar_Unvan]
GO
ALTER TABLE [dbo].[ogretmen]  WITH CHECK ADD  CONSTRAINT [CHK_MinChar_Yetki] CHECK  ((len([yetki])>=(2)))
GO
ALTER TABLE [dbo].[ogretmen] CHECK CONSTRAINT [CHK_MinChar_Yetki]
GO
ALTER TABLE [dbo].[OgretmenMusaitlik]  WITH CHECK ADD  CONSTRAINT [CHK_Mwwinimum2Harf] CHECK  ((len([gun])>=(2)))
GO
ALTER TABLE [dbo].[OgretmenMusaitlik] CHECK CONSTRAINT [CHK_Mwwinimum2Harf]
GO
/****** Object:  StoredProcedure [dbo].[SelectJoinDerser]    Script Date: 7.02.2024 00:49:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectJoinDerser]
AS
	SET NOCOUNT ON;
SELECT  dersler.id , dersler.ders,derslik.tur as derslik , dersler.kod, dersler.altanalan, dersler.subelesme
FROM     dersler JOIN derslik on derslik.id = dersler.derslikId
GO
USE [master]
GO
ALTER DATABASE [dersProgrami] SET  READ_WRITE 
GO
