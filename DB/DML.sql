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

/* TBL_CLASSES */
/* INSERT STATEMENT */
INSERT INTO tbl_classes (classroom_id, subject, teacher_id, start_time_day_id, end_time_day_id, day_id) VALUES 
('1', 'Bolean Algebra', '1', '1', '1', '1', '1');

/* SELECT STATEMENTS */
SELECT * FROM tbl_classes; 
SELECT * FROM tbl_classes WHERE class_id = 1;

/* SELECT STATEMENT INNER JOIN BY CLASS_ID */
SELECT
   CONCAT(tbl_first_names.first_names, " ",tbl_last_names.last_name) AS teacher_full_name,
   tbl_classrooms.classroom, 
   tbl_classes.subject,
   tbl_start_time_day.start_time_day,
   tbl_end_time_day.end_time_day,
   tbl_days.day
FROM tbl_classes
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
	WHERE class_id = 1;

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

/* TBL_CLASSROOMS */
/* INSERT STATEMENT */
INSERT INTO tbl_classrooms (classroom, ) VALUES 
('26 Culworth Court');

/* SELECT STATEMENTS */
SELECT * FROM tbl_classrooms; 
SELECT * FROM tbl_classrooms WHERE classroom_id = 1;

/* UPDATE STATEMENT */
UPDATE tbl_classrooms
SET 
	classroom = IFNULL(NULL, classroom)
WHERE classroom_id = 1;

/* DELETE STATEMENT */
DELETE FROM tbl_classrooms WHERE classroom_id = 1;

	/* END */

/* TBL_DATE_END */
/* INSERT STATEMENT */
INSERT INTO tbl_date_end (date_end) VALUES 
('2022-02-25');

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

/* PLACEHOLDERS FOR REMAINING TABLES TO WRITE THE SQL CODE
tbl_end_time_day
tbl_enrolments
tbl_file_types
tbl_first_names
tbl_genders
tbl_last_names
tbl_start_time_day

tbl_students
tbl_teachers
tbl_teaching_materials
*/

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