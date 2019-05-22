create table student(
	studentid int primary key,
	name varchar(50),
	address varchar(100),
	contact_number int,
	dob date,
	gender varchar(10),
	school varchar(50),
	medium varchar(10),
	availability varchar(10),
	guardianid int foreign key references guardian(guardian_id)
);

select * from student
select name as Name from details
select * from details
 delete from student

alter table student
drop column guardianid;

alter table student
add guardian_id int;

insert into student values 
(1,'S.Jayawardhana','imbulgoda',775870333,'1995-12-04','male','ABC college','english','available',1)

insert into student values 
(1,'santhoopa','imbulgoda',775870322,'male','ananda college','english','available',1)

create table guardian(
	guardian_id int primary key,
	name varchar(50),
	contact_number int,
	relationship varchar(50),
	address varchar(100)
);

select * from guardian

select mobile from details 

insert into guardian values (1,'Mrs. Jayawardhana',0716087722,'mother','kandy')

select max(studentid) from student
select max(guardian_id) from guardian

drop table student
delete from guardian
delete from student
select * from student
select * from guardian

select s.studentid as ID,s.name as Student,s.address as Address,s.contact_number as Contact_Number,s.dob as Date_of_Birth,s.gender as Gender,s.school as School,s.medium as Medium,g.name as Guardian_Name,g.relationship as Relationship,g.contact_number as Guardian_Mobile,g.address as Guardian_Address from guardian g,student s  where g.guardian_id=s.guardianid


select s.studentid as ID,s.name as Student,s.address as Address,s.contact_number as Contact_Number,s.dob as Date_of_Birth,s.gender as Gender,s.school as School,s.medium as Medium,g.name as Guardian_Name,g.relationship as Relationship,g.contact_number as Guardian_Mobile,g.address as Guardian_Address from guardian g,student s  where g.guardian_id=s.guardianid AND s.studentid=3
 
 update student set address='Gampaha',contact_number=775870322,school='ABC High school' where studentid=1;


 create table student_course_enroll(
	studentID int foreign key references student(studentid),
	classID int,
	jan varchar(15),
	feb varchar(15),
	march varchar(15),
	april varchar(15),
	may varchar(15),
	june varchar(15),
	july varchar(15),
	aug varchar(15),
	sept varchar(15),
	oct varchar(15),
	nov varchar(15),
	dec varchar(15),
	status varchar(15), 
	constraint pk primary key(studentID,classID)
 );

insert into  student_course_enroll values
(1,3,'NOT PAID','NOT PAID','NOT PAID','NOT PAID','NOT PAID','NOT PAID','NOT PAID','NOT PAID','NOT PAID','NOT PAID','NOT PAID','NOT PAID','ENROLLED')

select * from student_course_enroll

update student set availability='available' where studentid=
(select count(studentID) 
from student_course_enroll  
where studentid=3 AND status='ENROLLED')

create table lecturer(
	lecturerID int primary key,
	name VARCHAR(100),
	NIC VARCHAR(15),
	address VARCHAR(100),
	contact_number int,
	dob date,
	gender varchar(10),
	medium varchar(10),
	availability varchar(20),
	subject1 varchar(50),
	subject2 varchar(50),
	subject3 varchar(50),

);

insert into lecturer values 
(1,'Piyal Perera','953366565V','Nugegoda',0771234567,'1980-10-04','Male','English','AVAILABLE','Maths','Science','NULL');
select * from lecturer

select max(lecturerID) from lecturer

drop table lecturer

create table hall_one(
	time_slot VARCHAR(50),
	monday VARCHAR(30),
	tuesday VARCHAR(30),
	wednesday VARCHAR(30),
	thursday VARCHAR(30),
	friday VARCHAR(30),
	saturday VARCHAR(30),
	sunday VARCHAR(30),
	
);

create table class(
	classid int primary key,
	lecid int foreign key references lecturer(lecturerID),
	hallid int,
	subject varchar(50),
	grade varchar(50),
	year int,
	medium varchar(20),
	class_day varchar(20),
	time_slot varchar(50),
	total_fee int,
	institute_fee int,
	lecturer_fee int,
	availability varchar(25)
);
drop table class
select * from class
select max(classid) from class
insert into class values
(1,1,1,'English','Grade 7',2018,'English','Monday','8AM - 10AM',2000,200,1800,'available');
select name from lecturer

select time_slot from hall_one where monday='unallocated'

select * from hall_one

update hall_one set monday='allocated' where time_slot='8AM - 10AM' and monday='unallocated'

create table hall_two(
	time_slot VARCHAR(50),
	monday VARCHAR(30),
	tuesday VARCHAR(30),
	wednesday VARCHAR(30),
	thursday VARCHAR(30),
	friday VARCHAR(30),
	saturday VARCHAR(30),
	sunday VARCHAR(30),
	
);
select * from hall_one
select * from hall_two
select * from hall_three

update 
create table hall_three(
	time_slot VARCHAR(50),
	monday VARCHAR(30),
	tuesday VARCHAR(30),
	wednesday VARCHAR(30),
	thursday VARCHAR(30),
	friday VARCHAR(30),
	saturday VARCHAR(30),
	sunday VARCHAR(30),
	
);
select * from hall_three
select lecturerid as Lecturer_ID,name as Lecturer_Name,NIC,address as Address,contact_number as Contact_Number,dob as Date_of_Birth,gender as Gender,medium as Medium,subject1 as Subject_1,subject2 as Subject_2,subject3 as Subject_3 from lecturer where availability='available' 

select c.classid as Class_ID,l.name as Lecturer_Name,c.hallid as Hall_ID,c.subject as Subject,c.grade as Grade,c.year as Year,c.medium as Medium,c.class_day as Class_Day, c.time_slot as Time_Slot,c.total_fee as Monthly_Fee_Per_Student,c.institute_fee as Institute_Fee,c.lecturer_fee as Lecturer_Fee from class c,lecturer l where c.lecid=l.lecturerid  and c.availability='available'

select c.classid as Class_ID,l.name as Lecturer_Name,c.hallid as Hall_ID,c.subject as Subject,c.grade as Grade,c.year as Year,c.medium as Medium,c.class_day as Class_Day, c.time_slot as Time_Slot,c.total_fee as Monthly_Fee_Per_Student,c.institute_fee as Institute_Fee,c.lecturer_fee as Lecturer_Fee from class c,lecturer l where c.lecid=l.lecturerid  and c.availability='available' and c.classid=1

select * from class

delete from class where classid=3

select * from lecturer

select c.classid as Class_ID,l.name as Lecturer_Name,c.hallid as Hall_ID,c.subject as Subject,c.grade as Grade,c.year as Year,c.medium as Medium,c.class_day as Class_Day, c.time_slot as Time_Slot,c.total_fee as Monthly_Fee_Per_Student,c.institute_fee as Institute_Fee,c.lecturer_fee as Lecturer_Fee from class c,lecturer l where c.lecid=l.lecturerid  and c.availability='available' and c.lecid=1

select count(classID) from student_course_enroll  where classID=2 AND status='ENROLLED'
select * from student_course_enroll

update class set availability='available' where classid=1;

update lecturer set subject1='Science',subject2='Maths',subject3='null',contact_number=076123456,address='Kirulapona' where lecturerid=1;

select lecturerID AS Lecturer_ID,name as Name,NIC,address as Address,contact_number as Contact_Number,dob as Date_of_Birth,gender as Gender,medium as Medium,subject1 as Subject1,subject2 as Subject2,subject3 as Subject3 from lecturer where lecturerID=1

select count(lecid) from class where lecid=1 and availability='available'

update lectu