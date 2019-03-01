create table adminMaster
(
	id int primary key identity,
	name varchar(20),
	password varchar(15),
	emailid varchar(100)
)

create table facultymaster
(
	facid int primary key identity,
	facname varchar(20),
	emailid varchar(100),
	password varchar(20)
)

create table studentMaster
(
	sid int primary key identity,
	sname varchar(20),
	fname varchar(20),
	lname varchar(20),
	emailid varchar(100),
	password varchar(20),
	gender varchar(10),
	image varchar(50),
	college varchar(100),
	country varchar(40),
	state varchar(40),
	city varchar(40)
)

create table assignmentMaster
(
	aid int primary key identity,
	adate date,
	aurl varchar(100),
	subjectname varchar(100),
	description varchar(500)
)
create table exammaster
(
	eid int primary key identity,
	ename varchar(100),
	edate date,
	subjectname varchar(100),
	egroup varchar(100)
)

create table chatmaster
(
	cid int primary key identity,
	sendername varchar(100),
	recivername varchar(100),
	message varchar(200),
	mdate date,
	mtime time
)

create table feedbackmaster
(
	fid int primary key identity,
	fdesc varchar(100),
	fdate date,
	fitme time,
	femailid varchar(100)
)