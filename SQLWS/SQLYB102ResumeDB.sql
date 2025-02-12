use YB102ResumeDb

create table Abouts
(
	Id int primary key identity(1,1),
	Description nvarchar(500)
)

create table Addresses
(
	Id int primary key identity(1,1),
	City nvarchar(50) not null,
	Town nvarchar(50)not null,
	District nvarchar(100)not null,
	Street nvarchar (100)not null,
	BuildNumber smallint not null,
	FloorNumber tinyint not null,
	PostalCode char (5)null,
	ApartmentNumber smallint null
)