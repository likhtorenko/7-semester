create database [Journal]

use Journal
create table timetables (
[ID_table] int primary key identity (1, 1),
[ID_group] int not null,
[title] nvarchar(50) not null,
[date_start] date not null,
[date_end] date not null,
);
use Journal
create table weeks (
[ID_week] int primary key identity (1, 1),
[ID_table] int not null,
[date_start] date not null,
[date_end] date not null,
);
use Journal
create table days (
[ID_day] int primary key identity (1, 1),
[ID_week] int not null,
[name_day] nvarchar(50) not null,
[date] date not null,
);
use Journal
create table lessons (
[ID_lesson] int primary key identity (1, 1),
[ID_day] int not null,
[ID_teacher] int not null,
[ID_file] int not null,
[ID_comment] int not null,
[name] nvarchar(100) not null,
[post] int not null,
[time_start] time not null,
[time_end] time not null,
);
use Journal
create table files (
[ID_file] int primary key identity (1, 1),
[title] nvarchar(50) not null,
[data] varbinary(max) not null,
);
use Journal
create table grades (
[ID_grade] int primary key identity (1, 1),
[ID_student] int not null,
[ID_lesson] int not null,
[ID_comment] int not null,
[grade] nvarchar(50) not null,
);
use Journal
create table groups (
[ID_group] int primary key identity (1, 1),
[ID_teacher] int not null,
[title] nvarchar(50) not null,
);
use Journal
create table students (
[ID_student] int primary key identity (1, 1),
[ID_group] int not null,
[first_name] nvarchar(100) not null,
[last_name] nvarchar(100) not null,
[father_name] nvarchar(100) not null,
[email] varchar(250) not null,
[login] varchar(100) not null,
[pass] nvarchar(100) not null,
[ID_image] int not null,
[role] int not null,
);
use Journal
create table teachers (
[ID_teacher] int primary key identity (1, 1),
[first_name] nvarchar(100) not null,
[last_name] nvarchar(100) not null,
[father_name] nvarchar(100) not null,
[email] varchar(250) not null,
[login] varchar(100) not null,
[pass] nvarchar(100) not null,
[ID_image] int not null,
[role] int not null,
);
use Journal
create table images (
[ID_image] int primary key identity (1, 1),
[title] nvarchar(50) not null,
[data] varbinary(max) not null,
);
use Journal
create table comments (
[ID_comment] int primary key identity (1, 1),
[string] nvarchar(max) not null,
);