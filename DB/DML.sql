   /* START */
/* TBL_ADDRESSES */
/* INSERT STATEMENT */
INSERT INTO tbl_addresses (address_street, address_city, address_region, address_postcode) VALUES 
('26 Culworth Court', 'Coventry', 'West Midlands', 'CV6 5JY');

/* SELECT STATEMENTS */
SELECT * FROM tbl_addresses; 
SELECT * FROM tbl_addresses WHERE address_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_addresses
SET 
	address_street = IFNULL(NULL, address_street),
	address_city = IFNULL('Coventry', address_city),
	address_region = IFNULL(NULL, address_region),
	address_postcode = IFNULL('CV6 5JY', address_postcode)
WHERE address_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_addresses WHERE address_id = 1;

	/* END */


   /* START */
/* TBL_CLASSES */
/* INSERT STATEMENT */
INSERT INTO tbl_classes (classroom_id, subject, teacher_id, start_time_day_id, end_time_day_id, day_id) VALUES 
('1', 'Bolean Algebra', '1', '1', '1', '1');

/* INSERT STATEMENT WITH CHECKING */
INSERT INTO tbl_classrooms (classroom)
SELECT * FROM (SELECT 'M251') AS tmp
WHERE NOT EXISTS (
    SELECT classroom FROM tbl_classrooms WHERE classroom = 'M251'
) LIMIT 1;

/* SELECT STATEMENTS */
SELECT * FROM tbl_classes; 
SELECT * FROM tbl_classes WHERE class_id = 1;

/* SELECT STATEMENT LEFT INNER JOIN BY class_id */
SELECT
	tbl_classes.class_id,
	tbl_days.day,
	tbl_start_time_day.start_time_day,
    tbl_end_time_day.end_time_day,
    tbl_classrooms.classroom,
	tbl_first_names.first_names AS Teacher_FName,
	tbl_last_names.last_name AS Teacher_LName, 
	tbl_classes.subject
FROM
    tbl_classes
    INNER JOIN tbl_teachers 
        ON (tbl_classes.teacher_id = tbl_teachers.teacher_id)
    INNER JOIN tbl_classrooms 
        ON (tbl_classes.classrom_id = tbl_classrooms.classroom_id)
    INNER JOIN tbl_start_time_day 
        ON (tbl_classes.start_time_day_id = tbl_start_time_day.start_time_day_id)
    INNER JOIN tbl_end_time_day 
        ON (tbl_classes.end_time_day_id = tbl_end_time_day.end_time_day_id)
    INNER JOIN tbl_first_names 
        ON (tbl_teachers.first_name_Id = tbl_first_names.first_name_id)
    INNER JOIN tbl_last_names 
        ON (tbl_teachers.last_name_Id = tbl_last_names.last_name_id)
    INNER JOIN tbl_days 
        ON (tbl_classes.day_id = tbl_days.day_id)
	WHERE tbl_classes.class_id = '1';
   
/* SELECT STATEMENT LEFT INNER JOIN BY CLASSROOM NAME */
SELECT
	tbl_classes.class_id,
	tbl_days.day,
	tbl_start_time_day.start_time_day,
   tbl_end_time_day.end_time_day,
   tbl_classrooms.classroom,
	CONCAT(tbl_first_names.first_names, " ",tbl_last_names.last_name) AS Teacher_Name, 
	tbl_classes.subject
FROM
    tbl_classes
    INNER JOIN tbl_teachers 
        ON (tbl_classes.teacher_id = tbl_teachers.teacher_id)
    INNER JOIN tbl_classrooms 
        ON (tbl_classes.classrom_id = tbl_classrooms.classroom_id)
    INNER JOIN tbl_start_time_day 
        ON (tbl_classes.start_time_day_id = tbl_start_time_day.start_time_day_id)
    INNER JOIN tbl_end_time_day 
        ON (tbl_classes.end_time_day_id = tbl_end_time_day.end_time_day_id)
    INNER JOIN tbl_first_names 
        ON (tbl_teachers.first_name_Id = tbl_first_names.first_name_id)
    INNER JOIN tbl_last_names 
        ON (tbl_teachers.last_name_Id = tbl_last_names.last_name_id)
    INNER JOIN tbl_days 
        ON (tbl_classes.day_id = tbl_days.day_id) 
	WHERE tbl_classrooms.classroom = 'M250';

/* UPDATE STATEMENT */
UPDATE tbl_classes
SET 
	classroom_id = IFNULL(NULL, classroom_id),
	subject = IFNULL('Logic Gates', subject),
	teacher_id = IFNULL(NULL, teacher_id),
	start_time_day_id = IFNULL(NULL, start_time_day_id),
	end_time_day_id = IFNULL(NULL, end_time_day_id),
	day_id = IFNULL(NULL, day_id)
WHERE class_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_classes WHERE class_id = 1;

	/* END */


   /* START */
/* TBL_CLASSROOMS */
/* INSERT STATEMENT */
INSERT INTO tbl_classrooms (classroom) VALUES 
('M250');


/* INSERT STATEMENT WITH DUPLICATE CHECK */
INSERT INTO tbl_classrooms (classroom)
SELECT * FROM (SELECT 'M251') AS tmp
WHERE NOT EXISTS (
    SELECT classroom FROM tbl_classrooms WHERE classroom = 'M251'
) LIMIT 1;

/* SELECT STATEMENTS */
SELECT * FROM tbl_classrooms; 
SELECT * FROM tbl_classrooms WHERE classroom_id = 1;
SELECT * FROM tbl_classrooms WHERE classroom_name = 'M250';

/* UPDATE STATEMENT */
UPDATE tbl_classrooms
SET 
	classroom = IFNULL(NULL, classroom)
WHERE classroom_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_classrooms WHERE classroom_id = 1;

	/* END */


   /* START */
/* TBL_DATE_END */
/* INSERT STATEMENT */
INSERT INTO tbl_date_end (date_end) VALUES 
('2022-02-25');

/* INSERT STATEMENT WITH DUPLICATE CHECK */
INSERT INTO tbl_date_end (date_end)
SELECT * FROM (SELECT '2022-02-25') AS tmp
WHERE NOT EXISTS (
    SELECT date_end FROM tbl_date_end WHERE date_end = '2022-02-25'
) LIMIT 1;

/* SELECT STATEMENTS */
SELECT * FROM tbl_date_end; 
SELECT * FROM tbl_date_end WHERE date_end_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_date_end
SET 
	date_end = IFNULL('2022-02-25', date_end)
WHERE date_end_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_date_end WHERE date_end_id = 1;

	/* END */


   /* START */
/* TBL_DATE_START */
/* INSERT STATEMENT */
INSERT INTO tbl_date_start (date_start) VALUES 
('2022-01-17');

/* SELECT STATEMENTS */
SELECT * FROM tbl_date_start; 
SELECT * FROM tbl_date_start WHERE date_start_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_date_start
SET 
	date_start = IFNULL('2022-01-17', date_start)
WHERE date_start_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_date_end WHERE date_end_id = 1;

	/* END */


   /* START */
/* TBL_DAYS */
/* INSERT STATEMENT */
INSERT INTO tbl_days (day) VALUES 
('Monday');

/* SELECT STATEMENTS */
SELECT * FROM tbl_days; 
SELECT * FROM tbl_days WHERE day = 1;

/* UPDATE STATEMENT */
UPDATE tbl_days
SET 
	day = IFNULL('Monday', day)
WHERE day_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_days WHERE day_id = 1;

	/* END */


   /* START */
/* TBL_DOB */
/* INSERT STATEMENT */
INSERT INTO tbl_dob (dob) VALUES 
('1996-5-5');

/* SELECT STATEMENTS */
SELECT * FROM tbl_dob; 
SELECT * FROM tbl_dob WHERE dob_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_dob
SET 
	dob = IFNULL('1992-09-22', dob)
WHERE dob_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_dob WHERE dob_id = 1;

	/* END */


   /* START */
/* TBL_EMAILS */
/* INSERT STATEMENT */
INSERT INTO tbl_emails (e_mail_address) VALUES 
('test@example.com');

/* SELECT STATEMENT */
SELECT * FROM tbl_emails; 
SELECT * FROM tbl_emails WHERE e_mail_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_emails
SET 
	e_mail_address = IFNULL('ursus@coventry.ac.uk', e_mail_address)
WHERE e_mail_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_emails WHERE e_mail_id = 1;

	/* END */


   /* START */
/* TBL_END_TIME_DAY */
/* INSERT STATEMENT */
INSERT INTO tbl_end_time_day (end_time_day) VALUES 
('13:00:00');

/* SELECT STATEMENT */
SELECT * FROM tbl_end_time_day; 
SELECT * FROM tbl_end_time_day WHERE end_time_day_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_end_time_day
SET 
	end_time_day = IFNULL('13:30:00', end_time_day)
WHERE end_time_day_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_end_time_day WHERE e_mail_id = 1;

	/* END */


   /* START */
/* TBL_ENROLMENTS */
/* INSERT STATEMENT */
INSERT INTO tbl_enrolments (student_id,class_id,date_start_id,date_end_id) VALUES 
('1','1','1','1');

/* SELECT STATEMENT */
SELECT * FROM tbl_enrolments; 

/* UPDATE STATEMENT */
UPDATE tbl_enrolments
SET 
	student_id = IFNULL('2', student_id),
	class_id = IFNULL('2', class_id),
	date_start_id = IFNULL('2', date_start_id),
	date_end_id = IFNULL('2', date_end_id)
WHERE student_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_enrolments WHERE student_id = 1;
DELETE FROM tbl_enrolments WHERE class_id = 1;
	/* END */


   /* START */
/* TBL_FILE_TYPES */
/* INSERT STATEMENT */
INSERT INTO tbl_file_types (file_extension) VALUES 
('.txt'),
('.ppt');

/* SELECT STATEMENT */
SELECT * FROM tbl_end_time_day; 
SELECT * FROM tbl_end_time_day WHERE end_time_day_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_end_time_day
SET 
	end_time_day = IFNULL('13:30:00', end_time_day)
WHERE end_time_day_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_end_time_day WHERE e_mail_id = 1;

	/* END */


   /* START */
/* TBL_FIRST_NAMES */
/* INSERT STATEMENT */
INSERT INTO tbl_first_names (first_names) VALUES 
('Alexander');

/* SELECT STATEMENT */
SELECT * FROM tbl_first_names; 
SELECT * FROM tbl_end_time_day WHERE first_names_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_first_names
SET 
	first_names = IFNULL('Alex', first_names)
WHERE first_names_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_first_names WHERE first_names_id = 1;

	/* END */


   /* START */
/* tbl_genders */
/* INSERT STATEMENT */
INSERT INTO tbl_genders (gender) VALUES 
('None');

/* SELECT STATEMENT */
SELECT * FROM tbl_genders; 
SELECT * FROM tbl_genders WHERE gender_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_genders
SET 
	gender = IFNULL('male', gender)
WHERE gender_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_genders WHERE gender_id = 1;

	/* END */


   /* START */
/* TBL_LAST_NAMES */
/* INSERT STATEMENT */
INSERT INTO tbl_last_names (last_name) VALUES 
('Robert');

/* SELECT STATEMENT */
SELECT * FROM tbl_last_names; 
SELECT * FROM tbl_last_names WHERE last_name_id = 1;
SELECT last_name FROM tbl_last_names WHERE last_name = "Marley";

/* UPDATE STATEMENT */
UPDATE tbl_last_names
SET 
	last_name = IFNULL('Harley', last_name)
WHERE last_name_id = 1;

/* DELETE STATEMENT */
DELETE FROM last_name WHERE last_name_id = 1;

	/* END */


   /* START */
/* TBL_START_TIME_DAY */
/* INSERT STATEMENT */
INSERT INTO tbl_start_time_day (start_time_day) VALUES 
('09:30:00');

/* SELECT STATEMENT */
SELECT * FROM tbl_start_time_day; 
SELECT * FROM tbl_start_time_day WHERE start_time_day_id = 1;
SELECT start_time_day_id FROM tbl_start_time_day WHERE start_time_day = "09:00:00";

/* UPDATE STATEMENT */
UPDATE tbl_start_time_day
SET 
	start_time_day = IFNULL('Harley', start_time_day)
WHERE start_time_day_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_start_time_day WHERE start_time_day_id = 1;

	/* END */


  /* START */
/* tbl_parents_details */
/* INSERT STATEMENT */
INSERT INTO tbl_student_parents_details (first_name, last_name, phone_number_type, phone_number_main, phone_number_mobile) VALUES 
('Stefan', 'Ursu', 'Mobile', '07864143737', '07864143737');

/* SELECT STATEMENTS */
SELECT * FROM tbl_student_parents_details; 
SELECT * FROM tbl_student_parents_details WHERE parent_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_student_parents_details
SET 
	first_name = IFNULL('Test', first_name),
	last_name = IFNULL('Last Test', last_name),
	phone_number_type = IFNULL('Main', phone_number_type),
	phone_number_main = IFNULL('07869723145', phone_number_main),
	phone_number_home = IFNULL(NULL, phone_number_home),
	phone_number_mobile = IFNULL('07869723145', phone_number_mobile)
WHERE parent_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_student_parents_details WHERE parent_id = 1;

/* END */

  /* START */
/* TBL_STUDENTS */
/* INSERT STATEMENT */
INSERT INTO tbl_students (student_first_name_id, student_last_name_id, student_dob_id, gender_id, student_picture,student_e_mail_id, student_parent_id, student_address_home_id) VALUES 
('1','1','1','1','','1','1','1');

/* SELECT STATEMENT */
SELECT * FROM tbl_students; 
SELECT * FROM tbl_students WHERE student_id = 1;

/* SELECT STATEMENT WITH INNER JOIN */
SELECT
    tbl_students.student_id, 
    tbl_first_names.first_names,
    tbl_last_names.last_name,
    tbl_dob.dob,
    tbl_genders.gender,
    tbl_emails.e_mail_address,
    tbl_student_parents_details.first_name AS Parent_FirstName,
    tbl_student_parents_details.last_name AS Parent_LastName,
    tbl_student_parents_details.phone_number_type AS Parent_Phone_Number_Type,
    tbl_student_parents_details.phone_number_main AS Parent_Phone_Number_Main,
    tbl_student_parents_details.phone_number_home AS Parent_Phone_Number_Home,
    tbl_student_parents_details.phone_number_mobile AS Parent_Phone_Number_Mobile,
    tbl_addresses.address_street,
    tbl_addresses.address_city,
    tbl_addresses.address_region,
    tbl_addresses.address_postcode
FROM
    tbl_students
    INNER JOIN tbl_first_names 
        ON (tbl_students.student_first_name_id = tbl_first_names.first_name_id)
    INNER JOIN tbl_genders 
        ON (tbl_students.gender_id = tbl_genders.gender_id)
    INNER JOIN tbl_last_names 
        ON (tbl_students.student_last_name_id = tbl_last_names.last_name_id)
    INNER JOIN tbl_dob 
        ON (tbl_students.student_dob_id = tbl_dob.dob_id)
    INNER JOIN tbl_emails 
        ON (tbl_students.student_e_mail_id = tbl_emails.e_mail_id)
    INNER JOIN tbl_student_parents_details 
        ON (tbl_students.student_parent_id = tbl_student_parents_details.parent_id)
    INNER JOIN tbl_addresses 
        ON (tbl_students.student_address_home_id = tbl_addresses.address_id);

/* UPDATE STATEMENT */
UPDATE tbl_students
SET 
	student_first_name_id = IFNULL('1', student_first_name_id),
	student_last_name_id = IFNULL('1', student_last_name_id),
	student_dob_id = IFNULL('1', student_dob_id),
	gender_id = IFNULL('1', gender_id),
	student_picture = IFNULL('1', student_picture),
	student_e_mail_id = IFNULL('1', student_e_mail_id),
	student_parent_id = IFNULL('1', student_parent_id),
	student_address_home_id = IFNULL('1', student_address_home_id)
WHERE start_time_day_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_students WHERE student_id = 1;

	/* END */

  /* START */
/* TBL_TEACHERS */
/* INSERT STATEMENT */
INSERT INTO tbl_teachers (first_name_id, last_name_id, dob_id, gender_id, e_mail_id, payroll_nr, teachers_address_id) VALUES 
('1', '1', '1', '1', '1','234231','1');

/* SELECT STATEMENTS */
SELECT * FROM tbl_teachers; 
SELECT * FROM tbl_teachers WHERE teachers_id = 1;

/* SELECT STATEMENT WITH INNER JOIN */ 
SELECT
    tbl_teachers.teacher_id,
    tbl_first_names.first_names,
    tbl_last_names.last_name,
    tbl_dob.dob,
    tbl_genders.gender,
    tbl_emails.e_mail_address,
    tbl_teachers.payroll_nr,
    tbl_addresses.address_street,
    tbl_addresses.address_city,
    tbl_addresses.address_region,
    tbl_addresses.address_postcode
FROM
    tbl_teachers
    INNER JOIN tbl_emails 
        ON (tbl_teachers.e_mail_id = tbl_emails.e_mail_id)
    INNER JOIN tbl_first_names 
        ON (tbl_teachers.first_name_id = tbl_first_names.first_name_id)
    INNER JOIN tbl_genders 
        ON (tbl_teachers.gender_id = tbl_genders.gender_id)
    INNER JOIN tbl_last_names 
        ON (tbl_teachers.last_name_id = tbl_last_names.last_name_id)
    INNER JOIN tbl_dob 
        ON (tbl_teachers.dob_id = tbl_dob.dob_id)
    INNER JOIN tbl_addresses 
        ON (tbl_teachers.teachers_address_id = tbl_addresses.address_id);

/* UPDATE STATEMENT */
UPDATE tbl_teachers
SET 
	first_name_id = IFNULL('1', first_name_id),
	last_name_id = IFNULL('1', last_name_id),
	dob_id = IFNULL('1', dob_id),
	gender_id = IFNULL('1', gender_id),
	e_mail_id = IFNULL(NULL, e_mail_id),
	payroll_nr = IFNULL('1', payroll_nr),
	teachers_address_id = IFNULL('1', teachers_address_id),
WHERE teachers_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_teachers WHERE teachers_id = 1;

/* END */

  /* START */
/* tbl_teaching_materials */
/* INSERT STATEMENT */
INSERT INTO tbl_teaching_materials (file_name, file_extension_id, description, file_content, teacher_id) VALUES 
('Bolean Algebra', '1', 'Bolean Algebra Teaching Materials', '', '1');

/* SELECT STATEMENTS */
SELECT * FROM tbl_teaching_materials; 
SELECT * FROM tbl_teaching_materials WHERE teaching_id = 1;

/* SELECT STATEMENT WITH INNER JOIN FROM OTHER TABLES */
SELECT
    tbl_teaching_materials.teaching_id
    tbl_teaching_materials.file_name
    tbl_file_extensions.file_extension
    tbl_teaching_materials.description
    tbl_teaching_materials.file_content
    tbl_teachers.teacher_id
    tbl_first_names.first_names AS Teacher_First_Name
    tbl_last_names.last_name AS Teacher_Last_Name
FROM
    tbl_file_extensions, 
    tbl_teaching_materials
    INNER JOIN tbl_teachers 
        ON (tbl_teaching_materials.teacher_id = tbl_teachers.teacher_id)
    INNER JOIN tbl_first_names 
        ON (tbl_teachers.first_name_id = tbl_first_names.first_name_id)
    INNER JOIN tbl_last_names 
        ON (tbl_teachers.last_name_id = tbl_last_names.last_name_id);

/* UPDATE STATEMENT */
UPDATE tbl_teaching_materials
SET 
	file_name = IFNULL('Logic Gates', file_name),
	file_extension_id = IFNULL('1', last_name),
	description = IFNULL('Logic Gates Presentation', description),
	file_content = IFNULL('aa', phone_number_main),
	teacher_id = IFNULL('1', teacher_id)
WHERE teaching_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_teaching_materials WHERE teaching_id = 1;

/* END */
