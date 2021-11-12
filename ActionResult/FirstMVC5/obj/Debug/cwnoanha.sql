CREATE TABLE [dbo].[Aluno] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [nvarchar](max) NOT NULL,
    [Email] [nvarchar](max) NOT NULL,
    [CPF] [nvarchar](max) NOT NULL,
    [DataMatricula] [datetime] NOT NULL,
    [Ativo] [bit] NOT NULL,
    [Senha] [nvarchar](max) NOT NULL,
    [SenhaConfirmacao] [nvarchar](max) NOT NULL,
    CONSTRAINT [PK_dbo.Aluno] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'202111121243019_AutomaticMigration', N'FirstMVC5.Migrations.Configuration',  0x1F8B0800000000000400CD58DB6EDB46107D2FD07F20F8D4028ED61714680C2A8122D985D1C83642C7EF2372242DBA1796BB14A46FEB433FA9BF9059DE4949B614B546A117693873E6B23B6786FAE7AFBF838F6B29BC15A6866B35F42F06E7BE872AD231578BA19FD9F9BB5FFD8F1F7EFC21B889E5DA7BAEF4AE9C1E592A33F497D626D78C99688912CC40F228D546CFED20D29241ACD9E5F9F97B7671C190207CC2F2BCE04BA62C9798FFA09F63AD224C6C0662AA6314A694D3933047F5EE41A24920C2A17FCB5363A7CFE35F0613B0E07B23C181A20851CC7D0F94D2162CC578FDD5606853AD16614202104F9B04496F0EC26019FB75A37E681AE7972E0DD61856505166AC9647025E5C9575617DF3EFAAAE5FD78D2A774315B61B97755EBDA13F1299D2BED7F7743D16A9D36A57B63885416E71E6D5F2B3FA02D03D719F336F9C099BA5385498D914C499F798CD048F7EC7CD93FE03D5506542B4C3A2C0E8594740A2C7542798DACD179C97C1DEC5BEC7BA76AC6F589BB56C8A4CEE94BDBAF4BD7B720E3381F5A9B7B20EAD4EF137549882C5F811ACC554390CCCEBB6E5BDE7EB5E4BACBCD135A36EF1BD29AC3FA35AD8E5D0A7AF3ED56D8D71252923F8AA38351719D934C31D11BEECF54602176FEF76FC78FBF64E5D774F81DC459980CA3D09F189CBE3D14696AF7485F2496B81A08E0609512DE1ED2B91BB258A9CF3544204FABF8E20600D776C330A05628153DF54954D92C9CC09716D77B00BD1704930A674DECDB5000DD1B659CAF85E1342C1ED8392BE76055A87D4CC0D560C8E6AC0B03D132698429250115B13A7947861316EC6EFC2E3B95816182C323B28B98EB6F64454040BEC3D25D71469CEBDAE1566E08E691CCB2DB5CE01EC296EE5AA53E33E0B3725AFD4DDF7C2A43B75CBC3E80134C5BBA57C2411699E1AD651543368CB2E1FF42020DDC1E8632D32A9F64D8597AC0B8E6EDB1792C3114ABE6D4394A2C33172F26C23E482C3ED7B3CD846EA3D3A1CB364C33656293A1CA324C33646293A12A3C36C5B709DA7DBC801EB5DB9FEA5665BB7BAB755F47BE4257EE9ABD4DE6B9EE9F14950F6F6EB6BED56B3172ABE47255BF1D8357AB8311665D180E19F622C38E5DB284C41F1391A5B2C5E3E6D9797BDEDF8FFB3A932636271C8BAFAE6AB2377257D75393C7282B7B745B582345A42FA9384F5CFA76D80A741B5B6BAD380766E6A3155CE9EBCA9CDB83D6D4B3B2DB37D9BD731A8C76D53DB33FF807569FFB65490089DC6CCC55EC478DA22B54D68016BBFCD0713347CD140B8777B8591638A06B4D2B953735D959C726A4754A9F44E648A16E86AC128B57C0E91A5C7111A93EFC1CF20B2BC456618DFA987CC26991D198372263AEF73017BD97FBE2D76630E1E12F7CBFC1B295098DC75C783FA947111D771DFEEB83B7B20DC2D29E989A2A2F700825B6C6AA47BAD0E042ACB37C1049523B72794892030F3A04258E1F7C4460BFF675C40B4A9E6D27E90D70FA25BF660C261918234254663EFFEA162EE2FAA0FDF00AFDEB8A4D4120000 , N'6.4.4')

