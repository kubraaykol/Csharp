/*

	RESUMEDB

	TABLOLAR
	--Abouts+
	--Experiences+
	--Educations+
	--Skills
	--Interests
	--Awards

---------------------------------------
	--ABOUTS TABLE
	Id			=> int primary key
	----FirstName
	----LastName
	----Address      
	----Phone
	----Email
	Description nvarchar(500)
*/

create database YB102ResumeDb
go
use YB102ResumeDb
create table Abouts
(
	Id int primary key identity(1,1),
	Description nvarchar(500)
)

/*

	--------------------------------
	PERSONS TABLE
	Id			=> int primary key
	FirstName
	LastName
	BirthDate
	Images
	IdentityNumber

	*/
	create table Persons
	(
		Id int primary key identity(1,1),
		FirstName nvarchar(50) not null,
		LastName nvarchar(50) not null,
		Birthdate date not null,
		ImageUrl nvarchar(200) not null,
		IdentityNumber char(11) not null 
	)
	
	
	
	/*
	------------------------------
	ADDRESSES TABLE
	Id			=> int primary key
	City
	Town
	District
	Street
	BuildNumber
	Floor 
	ApatmentNumber
	PostalCode

	*/

	create table Addresses
	(
		Id int primary key identity(1,1),
		City nvarchar(50) not null,
		Town nvarchar(50) not null,
		District nvarchar(100) not null,
		Street nvarchar(100) not null,
		BuildNumber smallint not null,
		FloorNumber tinyint null,
		ApartmentNumber smallint null,
		PostalCode char(5) null
	)


	/*
	---------------------------------
	CONTACT TABLE
	Id			=> int primary key
	Phone1
	Phone2
	Email1
	Email2


	*/
	create table Contacts
	(
		Id int primary key identity(1,1),
		Phone char(15) not null,
		Phone2 char(15) null,
		Email nvarchar(50) not null,
		Email2 nvarchar(50) null
	)
	
	
	
	/*
-----------------------------------
	
	--SOCIALACCOUNTS TABLE
	Id			=> int primary key
	PlatformName
	Url (www.facebook.com/akincengiz
	UserName (akincengiz)
	Icon (fa-brands fa-facebook)

	*/
	create table SocialAccounts
	(
		Id int primary key identity(1,1),
		PlatformName nvarchar(50) not null,
		PlatformUrl nvarchar(100) not null,
		UserName nvarchar(50) not null,
		Icon nvarchar(50) not null
	)
	
	
	
	
	/*

	--------------------------------

	EXPERIENCES TABLE
		Id			=> int primary key
		Title		=> nvarchar(100)-not null
		CompanyName => nvarchar(100) - not null
		Description	=> nvarchar(500) - not null
		StartDate	=> date - not null
		EndDate		=> date - null

		*/
		create table Experiences
		(
			Id int primary key identity(1,1),
			Title nvarchar(100) not null,
			CompanyName nvarchar(100) not null,
			Description nvarchar(500) not null,
			StartDate date not null,
			EndDate date null
		)
		
		
		
		
		/*
----------------------------------------------

	EDUCATIONS TABLE
	Id			=> int primary key
	SchoolName	=> nvarchar(200) not null
	Faculty		=> nvarchar(200) null 
	Department	=> nvarchar(200) null
	GNO			=> decimal(5,2) not null
	StartDate	=> date - not null
	EndDate		=> date - null

	*/
	create table Educations
	(
		Id int primary key identity(1,1),
		SchoolName nvarchar(200) not null,
		Faculty varchar(200) null,
		Department nvarchar(200) null,
		GNO decimal(5,2) not null,
		StartDate date not null,
		EndDate date null
	)
	
	/*

	------------------------------------------
	SKILLS TABLE
	Id			=> int primary key
	Name		=> nvarchar(100) not null
	Icon		=> nvarchar(100) null
	SkillType	=> bit

	*/
	
	create table Skills
	(
		Id int primary key identity(1,1),
		Name nvarchar(100) not null,
		Icon nvarchar(100) null,
		SkillType bit not null
	)
	
	/*

	------------------------------------------
	INTERESTS TABLE
	Id			=> int primary key
	Description => nvarchar(500)
	*/
		create table Interests
		(
			Id int primary key identity(1,1),
			Description nvarchar(500) not null
		)
	
	/*
	CERTIFICATIONS TABLE
	Id			=> int primary key
	Institution => nvarchar(100)
	Title		=> nvarchar(100)
	Description => nvarchar(500)
	CertificateDate => date
	validity date => date

*/

	create table Certifications
	(
		Id int primary key identity(1,1),
		Institution nvarchar(100) not null,
		Title nvarchar(100) not null,
		Description nvarchar(500) not null,
		CertificateDate date not null,
		ValidityDate date null
	)



	/*
	
	Persons

	Students
	Teachers
	Lessons
	Notes
	Exams


	
	
	ADO.Net
	1
	2
	3
	4
	5
	6
	......
	20==> 1 -- 3 1 -- 1,00001
	21 kaydet
	getir
	entity framework 
	1
	2

	ssqlconn conn = "fdfdsfgdfdsfds";
	sqlcommand cmd = "dfdsfdsfdfdf @FirstName,@sdsad,@dfsd,@sdasa,;
	cmd.para
	.
	.
	.
	.
	.


	cmd.exe

	context.Add(product);
	context.SaveChanges()
	
	
	
	*/