   /* START */
/* TBL_ADDRESSES */

/* INSERT SP WITH DUPLICATE CHECKS */
DELIMITER //
CREATE PROCEDURE sp_insert_address(
    IN `address_street_par` VARCHAR(30),
	IN `address_city_par` VARCHAR(30),
	IN `address_region_par` VARCHAR(30),
	IN `address_postcode_par` VARCHAR(30))
BEGIN
INSERT INTO tbl_addresses (address_street, address_city, address_region, address_postcode)
SELECT * FROM (SELECT address_street_par, address_city_par, address_region_par,address_postcode_par) AS tmp
WHERE NOT EXISTS (
    SELECT address_street, address_city, address_region, address_postcode FROM tbl_addresses 
	 WHERE 
	 address_street = address_street_par AND 
	 address_city = address_city_par AND
	 address_region = address_region_par AND
	 address_postcode = address_postcode_par
) LIMIT 1;
END // 
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_address()
BEGIN
SELECT * FROM tbl_addresses;
END // 
DELIMITER ;

/* UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_address (   
    IN `address_id_par` INT, 
    IN `address_street_par` VARCHAR(30),
	IN `address_city_par` VARCHAR(30),
	IN `address_region_par` VARCHAR(30),
	IN `address_postcode_par` VARCHAR(30))
BEGIN
UPDATE tbl_addresses
SET 
	address_street = IFNULL(address_street_par, address_street),
	address_city = IFNULL(address_city_par, address_city),
	address_region = IFNULL(address_region_par, address_region),
	address_postcode = IFNULL(address_postcode_par, address_postcode)
WHERE address_id = address_id_par;
END // 
DELIMITER ;

/* DELETE STATEMENT */
DELIMITER //
CREATE PROCEDURE sp_delete_address(
   IN `address_id_par` INT)
BEGIN
DELETE FROM tbl_addresses WHERE address_id = address_id_par;
END // 
DELIMITER ;

	/* END */


   /* START */
/* TBL_CLASSES */
/* INSERT SP */
DELIMITER //
CREATE PROCEDURE sp_insert_classes(
    IN classrom_id_par INT,
    IN subject_par VARCHAR(30),
    IN teacher_id_par INT,
    IN start_time_day_id_par INT,
    IN end_time_day_id_par INT,
    IN day_id_par INT)
BEGIN
INSERT INTO tbl_classes (classroom_id, subject, teacher_id, start_time_day_id,end_time_day_id, day_id) VALUES 
(classrom_id_par, subject_par, teacher_id_par, start_time_day_id_par, end_time_day_id_par, classrom_id_par, day_id_par);
END // 
DELIMITER ;

/* SELECT SP BY class_id */
DELIMITER //
CREATE PROCEDURE sp_select_time_table_by_class_id(
    IN class_id_par INT
)

BEGIN
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
	WHERE tbl_classes.class_id = class_id_par;
END // 
DELIMITER ;

/* SELECT SP BY classroom_name */ 
DELIMITER //
CREATE PROCEDURE sp_select_time_table_by_classroom_name(
    IN classroom_nanme_par VARCHAR(10)
)
BEGIN
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
	WHERE tbl_classrooms.classroom = class_name_par;
END // 
DELIMITER ;

/* UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_timetable(
    IN class_id_par INT,
    IN classrom_id_par INT,
    IN subject_par VARCHAR(30),
    IN teacher_id_par INT,
    IN start_time_day_id_par INT,
    IN end_time_day_id_par INT,
    IN day_id_par INT
)
BEGIN
UPDATE tbl_classes
SET 
	classroom_id = IFNULL(classrom_id_par, classroom_id),
	subject = IFNULL(subject_par, subject),
	teacher_id = IFNULL(teacher_id_par, teacher_id),
	start_time_day_id = IFNULL(start_time_day_id_par, start_time_day_id),
	end_time_day_id = IFNULL(end_time_day_id_par, end_time_day_id),
	day_id = IFNULL(day_id_par, day_id)
WHERE class_id = class_id_par;
END // 
DELIMITER ;

/* DELETE SP */
DELIMITER //
CREATE PROCEDURE sp_delete_timetable(
    IN class_id_par INT
)
BEGIN
DELETE FROM tbl_classes WHERE class_id = class_id_par;
END //
DELIMITER ;

	/* END */


   /* START */
/* TBL_CLASSROOMS */
/* INSERT SP WITH CHECKING */
DELIMITER //
CREATE PROCEDURE sp_insert_classroom(
    IN classroom_par VARCHAR(10)
)
BEGIN
INSERT INTO tbl_classrooms (classroom)
SELECT * FROM (SELECT classroom_par) AS tmp
WHERE NOT EXISTS (
    SELECT classroom FROM tbl_classrooms WHERE classroom = classroom_par
) LIMIT 1;
END // 
DELIMITER ;

/* SELECT SP ALL */
DELIMITER //
CREATE PROCEDURE sp_select_classrooms()
BEGIN
SELECT * FROM tbl_classrooms; 
END // 
DELIMITER ;

/* SELECT SP by classroom_id */
DELIMITER //
CREATE PROCEDURE sp_select_classroom_by_id(
    IN classroom_id_par INT
)
BEGIN
SELECT * FROM tbl_classrooms WHERE classroom_id = classroom_id_par;
END // 
DELIMITER ;

/* SELECT SP by classroom_name */
DELIMITER //
CREATE PROCEDURE sp_select_classroom_by_name(
    IN classroom_name_par VARCHAR(10)
)
BEGIN
SELECT * FROM tbl_classrooms WHERE classroom_name = classroom_name_par;
END // 
DELIMITER ;

/* UPDATE SP BY classroom_id */

DELIMITER //
CREATE PROCEDURE sp_update_classroom_by_id(
    IN classroom_id_par INT,
    IN classroom_name_par VARCHAR(10)
)
BEGIN
UPDATE tbl_classrooms
SET 
	classroom = IFNULL(classroom_name_par, classroom)
WHERE classroom_id = class_id_par;
END // 
DELIMITER ;

/* UPDATE SP BY classroom_name */

DELIMITER //
CREATE PROCEDURE sp_update_classroom_by_name(
    IN classroom_id_par INT,
    IN classroom_name_old_par VARCHAR(10),
    IN classroom_name_new_par VARCHAR(10)
)
BEGIN
UPDATE tbl_classrooms
SET 
	classroom = IFNULL(classroom_name_new_par, classroom)
WHERE classroom_name = class_name_old_par;
END // 
DELIMITER ;

/* DELETE SP by classroom_id */
DELIMITER //
CREATE PROCEDURE sp_delete_classroom_by_id(
    IN classrom_id_par INT,
)
BEGIN
DELETE FROM tbl_classrooms WHERE classroom_id = classrom_id_par;
END // 
DELIMITER ;

/* DELETE SP by classroom_name */
DELIMITER //
CREATE PROCEDURE sp_delete_classroom_by_name(
    IN classrom_id_name VARCHAR(10),
)
BEGIN
DELETE FROM tbl_classrooms WHERE classroom_name = classrom_name_par;
END // 
DELIMITER ;

	/* END */


   /* START */
/* TBL_DATE_END */
/* INSERT SP WITH DUPLICATE CHECK */
DELIMITER //
CREATE PROCEDURE sp_insert_date_end(
    IN date_end_par DATE
)
BEGIN
INSERT INTO tbl_date_end (date_end)
SELECT * FROM (SELECT date_end_par) AS tmp
WHERE NOT EXISTS (
    SELECT date_end FROM tbl_date_end WHERE date_end = date_end_par
) LIMIT 1;
END //
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_date_end(
)
BEGIN
SELECT * FROM tbl_date_end; 
END // 
DELIMITER ;

/* UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_date_end_by_date(
    IN date_end_old_par DATE,
    IN date_end_new_par DATE
)
BEGIN
UPDATE tbl_date_end
SET 
	date_end = IFNULL(date_end_new_par, date_end)
WHERE date_end = date_end_old_par;
END // 
DELIMITER ;

/*DELETE SP */
DELIMITER //
CREATE PROCEDURE sp_delete_date_end_by_id(
    IN date_end_id_par INT 
)
BEGIN
DELETE FROM tbl_date_end WHERE date_end_id = date_end_id_par;
END // 
DELIMITER ;


	/* END */


   /* START */
/* TBL_DATE_START */
/* INSERT SP WITH DUPLICATE CHECK */
DELIMITER //
CREATE PROCEDURE sp_insert_date_start(
    IN date_start_par DATE
)
BEGIN
INSERT INTO tbl_date_start (date_start)
SELECT * FROM (SELECT date_start_par) AS tmp
WHERE NOT EXISTS (
    SELECT date_start FROM tbl_date_start WHERE date_start = date_start_par
) LIMIT 1;
END //
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_date_start(
)
BEGIN
SELECT * FROM tbl_date_start; 
END // 
DELIMITER ;

/* UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_date_start_by_date(
    IN date_start_old_par DATE,
    IN date_start_new_par DATE
)
BEGIN
UPDATE tbl_date_start
SET 
	date_start = IFNULL(date_start_new_par, date_start)
WHERE date_start = date_start_old_par;
END // 
DELIMITER ;

/*DELETE SP */
DELIMITER //
CREATE PROCEDURE sp_delete_date_start_by_id(
    IN date_start_id_par INT 
)
BEGIN
DELETE FROM tbl_date_start WHERE date_start_id = date_start_id_par;
END // 
DELIMITER ;


	/* END */


/* TBL_DAYS */
/* INSERT SP WITH DUPLICATE CHECK */
DELIMITER //
CREATE PROCEDURE sp_insert_day(
    IN day_par VARCHAR(10)
)
BEGIN
INSERT INTO tbl_days (day)
SELECT * FROM (SELECT day_par) AS tmp
WHERE NOT EXISTS (
    SELECT day FROM tbl_days WHERE day = day_par
) LIMIT 1;
END //
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_day(
)
BEGIN
SELECT * FROM tbl_days; 
END // 
DELIMITER ;

/* UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_day_by_day(
    IN day_old_par VARCHAR(10),
    IN day_new_par VARCHAR(10)
)
BEGIN
UPDATE tbl_days
SET 
	day = IFNULL(day_new_par, day)
WHERE day = day_old_par;
END // 
DELIMITER ;

/*DELETE SP */
DELIMITER //
CREATE PROCEDURE sp_delete_day_by_id(
    IN day_id_par INT 
)
BEGIN
DELETE FROM tbl_days WHERE day_id = day_id_par;
END // 
DELIMITER ;

	/* END */


   /* START */
/* TBL_DOB */
DELIMITER //
CREATE PROCEDURE sp_insert_dob(
    IN dob_par DATE
)
BEGIN
INSERT INTO tbl_dob (dob)
SELECT * FROM (SELECT dob_par) AS tmp
WHERE NOT EXISTS (
    SELECT dob FROM tbl_dob WHERE dob = dob_par
) LIMIT 1;
END //
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_dob(
)
BEGIN
SELECT * FROM tbl_dob; 
END // 
DELIMITER ;

/* UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_dob_by_date(
    IN dob_old_par DATE,
    IN dob_new_par DATE
)
BEGIN
UPDATE tbl_dob
SET 
	dob = IFNULL(dob_new_par, dob)
WHERE dob = dob_old_par;
END // 
DELIMITER ;

/*DELETE SP */
DELIMITER //
CREATE PROCEDURE sp_delete_dob_by_id(
    IN dob_id_par INT 
)
BEGIN
DELETE FROM tbl_dob WHERE dob_id = dob_id_par;
END // 
DELIMITER ;

	/* END */


   /* START */
/* TBL_EMAILS */
/* INSERT SP WITH DUPLICATE CHECK */
DELIMITER //
CREATE PROCEDURE sp_insert_e_mail_address(
    IN e_mail_address_par VARCHAR(255)
)
BEGIN
INSERT INTO tbl_emails (e_mail_address)
SELECT * FROM (SELECT e_mail_address_par) AS tmp
WHERE NOT EXISTS (
    SELECT e_mail_address FROM tbl_emails WHERE e_mail_address = e_mail_address_par
) LIMIT 1;
END //
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_e_mail_address(
)
BEGIN
SELECT * FROM tbl_emails; 
END // 
DELIMITER ;

/* UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_e_mail_address_by_e_mail(
    IN e_mail_address_old_par VARCHAR(255),
    IN e_mail_address_new_par VARCHAR(255)
)
BEGIN
UPDATE tbl_emails
SET 
	e_mail_address = IFNULL(e_mail_address_new_par, e_mail_address)
WHERE e_mail_address = e_mail_address_old_par;
END // 
DELIMITER ;

/*DELETE SP */
DELIMITER //
CREATE PROCEDURE sp_delete_e_mail_address_by_id(
    IN e_mail_id_par INT 
)
BEGIN
DELETE FROM tbl_emails WHERE e_mail_id = e_mail_id_par;
END // 
DELIMITER ;

	/* END */

   /* START */
/* TBL_END_TIME_DAY */
/* INSERT SP WITH DUPLICATE CHECK */
DELIMITER //
CREATE PROCEDURE sp_insert_end_time_day(
    IN end_time_day_par TIME
)
BEGIN
INSERT INTO tbl_end_time_day (end_time_day)
SELECT * FROM (SELECT end_time_day_par) AS tmp
WHERE NOT EXISTS (
    SELECT end_time_day FROM tbl_end_time_day WHERE end_time_day = end_time_day_par
) LIMIT 1;
END //
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_end_time_day(
)
BEGIN
SELECT * FROM tbl_end_time_day; 
END // 
DELIMITER ;

/* UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_end_time_day_by_end_time_day(
    IN end_time_day_old_par TIME,
    IN end_time_day_new_par TIME
)
BEGIN
UPDATE tbl_end_time_day
SET 
	end_time_day = IFNULL(end_time_day_new_par, end_time_day)
WHERE end_time_day = end_time_day_old_par;
END // 
DELIMITER ;

/*DELETE SP */
DELIMITER //
CREATE PROCEDURE sp_delete_end_time_day_by_id(
    IN end_time_day_id_par INT 
)
BEGIN
DELETE FROM tbl_end_time_day WHERE end_time_day_id = end_time_day_id_par;
END // 
DELIMITER ;
	/* END */


   /* START */
/* TBL_ENROLMENTS */
/* INSERT SP WITH DUPLICATE CHECKS */
DELIMITER //
CREATE PROCEDURE sp_insert_enrolments(
    IN `student_id_par` INT,
	IN `class_id_par` INT,
	IN `date_start_id_par` INT,
	IN `date_end_id_par` INT
)
BEGIN
INSERT INTO tbl_enrolments (student_id, class_id, date_start_id, date_end_id)
SELECT * FROM (SELECT student_id_par, class_id_par, date_start_id_par,date_end_id_par) AS tmp
WHERE NOT EXISTS (
    SELECT student_id, class_id, date_start_id, date_end_i FROM tbl_enrolments 
	 WHERE 
	 student_id = student_id_par AND 
	 class_id = class_id_par AND
	 date_start_id = date_start_id_par AND
	 date_end_id = date_end_id_par
) LIMIT 1;
END // 
DELIMITER ;

/*SELECT SP INNER JOIN */
DELIMITER //
CREATE PROCEDURE sp_select_enrolments(
)
BEGIN
SELECT
    tbl_students.student_first_name_id AS Student_FName,
    tbl_students.student_last_name_id AS Student_LName,
    tbl_classrooms.classroom AS Classroom,
    tbl_classes.subject AS Subject,
    tbl_teachers.first_name_id AS Teacher_FNane,
    tbl_teachers.last_name_id AS Teacher_LName,
    tbl_date_start.date_start AS StartDate,
    tbl_date_end.date_end AS EndDate
FROM
    tbl_enrolments
    INNER JOIN tbl_students 
        ON (tbl_enrolments.student_id = tbl_students.student_id)
    INNER JOIN tbl_classes 
        ON (tbl_enrolments.class_id = tbl_classes.class_id)
    INNER JOIN tbl_date_start 
        ON (tbl_enrolments.date_start_id = tbl_date_start.date_start_id)
    INNER JOIN tbl_date_end 
        ON (tbl_enrolments.date_end_id = tbl_date_end.date_end_id)
    INNER JOIN tbl_classrooms 
        ON (tbl_classes.classroom_id = tbl_classrooms.classroom_id)
    INNER JOIN tbl_teachers 
        ON (tbl_classes.teacher_id = tbl_teachers.teacher_id);
END // 
DELIMITER ;

/* UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_enrolments_by_student_id(
    IN student_id_par INT,
    IN class_id_par INT,
    IN date_start_id_par INT,
    IN date_end_id_par INT,
)
BEGIN
UPDATE tbl_enrolments
SET 
	student_id = IFNULL(student_id_par, student_id),
	class_id = IFNULL(class_id_par, class_id),
	date_start_id = IFNULL(date_start_id_par, date_start_id),
	date_end_id = IFNULL(date_end_id_par, date_end_id)
WHERE student_id = student_id_par;
END // 
DELIMITER ;

/* DELETE SP */
DELIMITER //
CREATE PROCEDURE sp_delete_enrolment_by_student_id(
    IN student_id_par INT
)
BEGIN
DELETE FROM tbl_enrolments WHERE student_id = student_id_par;
END // 
DELIMITER ;

	/* END */


   /* START */
/* TBL_FILE_EXTENSIONS */

/* INSERT SP */
DELIMITER //
CREATE PROCEDURE sp_insert_file_extension(
    IN file_extension_par VARCHAR(6)
)
BEGIN
INSERT INTO tbl_file_extensions (file_extension) VALUES (file_extension_par);
END // 
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_file_extension(
)
BEGIN
SELECT * FROM tbl_file_extensions; 
END // 
DELIMITER ;

/*UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_file_extension(
    IN file_extension_old_par VARCHAR(6),
    IN file_extension_new_par VARCHAR(6)
)
BEGIN
UPDATE tbl_file_extensions
SET 
	file_extension = IFNULL(file_extension_new_par, file_extension)
WHERE file_extension = file_extension_old_par;
END // 
DELIMITER ;

/* DELETE SP BY file_extension */
DELIMITER //
CREATE PROCEDURE sp_delete_file_extension(
    in file_extension_par VARCHAR(6),
)
BEGIN
DELETE FROM tbl_file_extensions WHERE file_extension = file_extension_par;
END // 
DELIMITER ;

	/* END */


   /* START */
/* TBL_FIRST_NAMES */
/* INSERT SP */
DELIMITER //
CREATE PROCEDURE sp_insert_first_name(
    IN first_name_par VARCHAR(10)
)
BEGIN
INSERT INTO tbl_first_names (first_name) VALUES (first_name_par);
END // 
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_first_name(
)
BEGIN
SELECT * FROM tbl_first_names; 
END // 
DELIMITER ;

/*UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_first_name(
    IN first_name_old_par VARCHAR(10),
    IN first_name_new_par VARCHAR(10)
)
BEGIN
UPDATE tbl_first_names
SET 
	first_name = IFNULL(first_name_new_par, first_name)
WHERE first_name = first_name_old_par;
END // 
DELIMITER ;

/* DELETE SP BY first_name */
DELIMITER //
CREATE PROCEDURE sp_delete_first_name(
    in first_name_par VARCHAR(10),
)
BEGIN
DELETE FROM tbl_first_names WHERE first_name = first_name_par;
END // 
DELIMITER ;

	/* END */


   /* START */
/* TBL_GENDERS */
/* INSERT SP */
DELIMITER //
CREATE PROCEDURE sp_insert_gender(
    IN gender_par VARCHAR(6)
)
BEGIN
INSERT INTO tbl_genders (gender) VALUES (gender_par);
END // 
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_genders(
)
BEGIN
SELECT * FROM tbl_genders; 
END // 
DELIMITER ;

/*UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_genders(
    IN genders_old_par VARCHAR(6),
    IN genders_new_par VARCHAR(6)
)
BEGIN
UPDATE tbl_genders
SET 
	gender = IFNULL(genders_new_par, gender)
WHERE genders = genders_old_par;
END // 
DELIMITER ;

/* DELETE SP BY genders */
DELIMITER //
CREATE PROCEDURE sp_delete_gender(
    in gender_par VARCHAR(6),
)
BEGIN
DELETE FROM tbl_genders WHERE gender = gender_par;
END // 
DELIMITER ;

	/* END */


   /* START */
/* TBL_LAST_NAMES */
/* INSERT SP */
DELIMITER //
CREATE PROCEDURE sp_insert_last_name(
    IN last_name_par VARCHAR(10)
)
BEGIN
INSERT INTO tbl_last_names (last_name) VALUES (last_name_par);
END // 
DELIMITER ;

/* SELECT SP */
DELIMITER //
CREATE PROCEDURE sp_select_last_name(
)
BEGIN
SELECT * FROM tbl_last_names; 
END // 
DELIMITER ;

/*UPDATE SP */
DELIMITER //
CREATE PROCEDURE sp_update_last_name(
    IN last_name_old_par VARCHAR(10),
    IN last_name_new_par VARCHAR(10)
)
BEGIN
UPDATE tbl_last_names
SET 
	last_name = IFNULL(last_name_new_par, last_name)
WHERE last_name = last_name_old_par;
END // 
DELIMITER ;

/* DELETE SP BY last_name */
DELIMITER //
CREATE PROCEDURE sp_delete_last_name(
    in last_name_par VARCHAR(10),
)
BEGIN
DELETE FROM tbl_last_names WHERE last_name = last_name_par;
END // 
DELIMITER ;

	/* END */