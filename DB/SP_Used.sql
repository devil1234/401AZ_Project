
/* "Sp_SelectAddressByAdddressCity" */
DELIMITER //
CREATE PROCEDURE sp_select_address_by_adddress_city(
    IN address_city_par VARCHAR(30)
)
BEGIN
SELECT * FROM tbl_addresses WHERE address_city = address_city_par;
END // 
DELIMITER ;

/* "Sp_InsertAddress" */
DELIMITER //
CREATE PROCEDURE sp_insert_address(
    IN address_street_par VARCHAR(30),
	IN address_city_par VARCHAR(30),
	IN address_region_par VARCHAR(30),
	IN address_postcode_par VARCHAR(30))
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

/* "Sp_UpdateAddress" */
DELIMITER //
CREATE PROCEDURE sp_update_address (   
    IN address_id_par INT, 
    IN address_street_par VARCHAR(30),
	IN address_city_par VARCHAR(30),
	IN address_region_par VARCHAR(30),
	IN address_postcode_par VARCHAR(30))
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

/* "Sp_InsertClassroom" */
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

/* "Sp_SelectClassroomByName" */
DELIMITER //
CREATE PROCEDURE sp_select_classroom_by_name(
    IN classroom_par VARCHAR(10)
)
BEGIN
SELECT classroom_id FROM tbl_classrooms WHERE classroom = classroom_par;
END // 
DELIMITER ;

/* "Sp_UpdateClassroomByName" */
DELIMITER //
CREATE PROCEDURE sp_update_classroom_by_name(
    IN classroom_old_par VARCHAR(10),
    IN classroom_new_par VARCHAR(10)
)
BEGIN
UPDATE tbl_classrooms
SET 
	classroom = IFNULL(classroom_new_par, classroom)
WHERE classroom = classroom_old_par;
END // 
DELIMITER ;

/* "Sp_InsertDateEnd" */
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

/* "Sp_SelectDateEndByDate" */
DELIMITER //
CREATE PROCEDURE sp_select_date_end_by_date(
    IN date_end_par DATE
)
BEGIN
SELECT * FROM tbl_date_end WHERE date_end = date_end_par;
END //
DELIMITER ;

/* "Sp_UpdateDateEndByDate" */
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

/* "Sp_InsertDateStart" */
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

/* "Sp_SelectDateStartByDate" */
DELIMITER //
CREATE PROCEDURE sp_select_date_start_by_date(
    IN date_start_par DATE
)
BEGIN
SELECT * FROM tbl_date_start WHERE date_start= date_start_par;
END //
DELIMITER ;

/* "Sp_UpdateDateStartByDate" */
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

/* "Sp_SelectDay" */
DELIMITER //
CREATE PROCEDURE sp_select_day(
)
BEGIN
SELECT * FROM tbl_days; 
END // 
DELIMITER ;

/* "Sp_InsertDob" */
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

/* "Sp_SelectDobidByDob" */
DELIMITER //
CREATE PROCEDURE sp_select_dobid_by_dob(
    IN dob_par DATE
)
BEGIN
SELECT * FROM tbl_dob WHERE dob = dob_par; 
END // 
DELIMITER ;

/* "Sp_UpdateDobByDate" */
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

/* "Sp_InsertEMailAddress" */
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

/* "Sp_SelectEMailAddressIdByEmail" */
DELIMITER //
CREATE PROCEDURE sp_select_e_mail_address_id_by_email(
    IN e_mail_address_par VARCHAR(255)
)
BEGIN
SELECT * FROM tbl_emails WHERE e_mail_address = e_mail_address_par; 
END // 
DELIMITER ;

/* "Sp_UpdateEMailAddressByEMail" */
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

/* "Sp_InsertEndTimeDay" */
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

/* "Sp_SelectEndTimeDayByStd" */
DELIMITER //
CREATE PROCEDURE sp_select_end_time_day_by_std(
    IN end_time_day_par TIME
)
BEGIN
SELECT * FROM tbl_end_time_day WHERE end_time_day = end_time_day_par;
END // 
DELIMITER ;

/* "Sp_UpdateEndTimeDayByEndTimeDay" */
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

/* "Sp_SelectEnrolments" */
DELIMITER //
CREATE PROCEDURE sp_select_enrolments(
)
BEGIN
SELECT
    tbl_students.student_id,
    tbl_classes.class_id,
    tbl_first_names.first_name,
    tbl_last_names.last_name,
    tbl_classrooms.classroom,
    tbl_classes.subject,
    tbl_date_start.date_start,
    tbl_date_end.date_end,
    tbl_classes.teacher_id
FROM
    tbl_enrolments
    INNER JOIN tbl_students 
        ON (tbl_enrolments.student_id = tbl_students.student_id)
    INNER JOIN tbl_date_end 
        ON (tbl_enrolments.date_end_id = tbl_date_end.date_end_id)
    INNER JOIN tbl_date_start 
        ON (tbl_enrolments.date_start_id = tbl_date_start.date_start_id)
    INNER JOIN tbl_first_names 
        ON (tbl_students.student_first_name_id = tbl_first_names.first_name_id)
    INNER JOIN tbl_last_names 
        ON (tbl_students.student_last_name_id = tbl_last_names.last_name_id)
    INNER JOIN tbl_classes 
        ON (tbl_enrolments.class_id = tbl_classes.class_id)
    INNER JOIN tbl_classrooms 
        ON (tbl_classes.classroom_id = tbl_classrooms.classroom_id);
END // 
DELIMITER ;

/* "Sp_SelectEnrolmentsByStudentId" */
DELIMITER //
CREATE PROCEDURE sp_select_enrolments_by_student_id(
    IN student_id_par INT
)
BEGIN
SELECT
    tbl_students.student_id,
    tbl_classes.class_id,
    tbl_first_names.first_name,
    tbl_last_names.last_name,
    tbl_classrooms.classroom,
    tbl_classes.subject,
    tbl_date_start.date_start,
    tbl_date_end.date_end,
    tbl_classes.teacher_id
FROM
    tbl_enrolments
    INNER JOIN tbl_students 
        ON (tbl_enrolments.student_id = tbl_students.student_id)
    INNER JOIN tbl_date_end 
        ON (tbl_enrolments.date_end_id = tbl_date_end.date_end_id)
    INNER JOIN tbl_date_start 
        ON (tbl_enrolments.date_start_id = tbl_date_start.date_start_id)
    INNER JOIN tbl_first_names 
        ON (tbl_students.student_first_name_id = tbl_first_names.first_name_id)
    INNER JOIN tbl_last_names 
        ON (tbl_students.student_last_name_id = tbl_last_names.last_name_id)
    INNER JOIN tbl_classes 
        ON (tbl_enrolments.class_id = tbl_classes.class_id)
    INNER JOIN tbl_classrooms 
        ON (tbl_classes.classroom_id = tbl_classrooms.classroom_id)
    WHERE tbl_students.student_id = student_id_par;
END // 
DELIMITER ;

/* "Sp_DeleteEnrolmentByClassId" */
DELIMITER //
CREATE PROCEDURE sp_delete_enrolment_by_class_id(
    IN class_id_par INT
)
BEGIN
DELETE FROM tbl_enrolments WHERE class_id = class_id_par;
END // 
DELIMITER ;

/* "Sp_InsertEnrolments" */
DELIMITER //
CREATE PROCEDURE sp_insert_enrolments(
    IN student_id_par INT,
	IN class_id_par INT,
	IN date_start_id_par INT,
	IN date_end_id_par INT
)
BEGIN
INSERT INTO tbl_enrolments (student_id, class_id, date_start_id, date_end_id)
SELECT * FROM (SELECT student_id_par, class_id_par, date_start_id_par,date_end_id_par) AS tmp
WHERE NOT EXISTS (
    SELECT student_id, class_id, date_start_id, date_end_id FROM tbl_enrolments 
	 WHERE 
	 student_id = student_id_par AND 
	 class_id = class_id_par AND
	 date_start_id = date_start_id_par AND
	 date_end_id = date_end_id_par
) LIMIT 1;
END // 
DELIMITER ;

/* "Sp_UpdateEnrolmentsByStudentId" */
DELIMITER //
CREATE PROCEDURE sp_update_enrolments_by_student_id(
    IN student_id_par INT,
    IN class_id_par INT,
    IN date_start_id_par INT,
    IN date_end_id_par INT
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

/* "Sp_SelectFileExtensionByFileExtension" */
DELIMITER //
CREATE PROCEDURE sp_select_file_extension_by_file_extension(
    IN file_extension_par VARCHAR(6)
)
BEGIN
SELECT file_extension_id FROM tbl_file_extensions WHERE file_extension = file_extension_par; 
END // 
DELIMITER ;

/* "Sp_InsertFirstName" */
DELIMITER //
CREATE PROCEDURE sp_insert_first_name(
    IN first_name_par VARCHAR(10)
)
BEGIN
INSERT INTO tbl_first_names (first_name) VALUES (first_name_par);
END // 
DELIMITER ;

/* "Sp_SelectFirstNameByFirstName" */
DELIMITER //
CREATE PROCEDURE sp_select_first_name_by_first_name(
    IN first_name_par VARCHAR(10)
)
BEGIN
SELECT * FROM tbl_first_names WHERE first_name = first_name_par;
END //
DELIMITER ;

/* "Sp_UpdateFirstName" */
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

/* "Sp_SelectGenders" */
DELIMITER //
CREATE PROCEDURE sp_select_genders(
)
BEGIN
SELECT * FROM tbl_genders; 
END // 
DELIMITER ;

/* "Sp_InsertLastName" */
DELIMITER //
CREATE PROCEDURE sp_insert_last_name(
    IN last_name_par VARCHAR(10)
)
BEGIN
INSERT INTO tbl_last_names (last_name) VALUES (last_name_par);
END // 
DELIMITER ;

/* "Sp_SelectLastNameByLastName" */
DELIMITER //
CREATE PROCEDURE sp_select_last_name_by_last_name(
    IN last_name_par VARCHAR(10)
)
BEGIN
SELECT * FROM tbl_last_names WHERE last_name = last_name_par;
END //
DELIMITER ;

/* "Sp_UpdateLastName" */
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

/* "Sp_InsertStartTimeDay" */
DELIMITER //
CREATE PROCEDURE sp_insert_start_time_day(
    IN start_time_day_par TIME
)
BEGIN
INSERT INTO tbl_start_time_day (start_time_day) VALUES (start_time_day_par);
END // 
DELIMITER ;

/* "Sp_SelectStartTimeDayByStd" */
DELIMITER //
CREATE PROCEDURE sp_select_start_time_day_by_std(
    IN start_time_day_par TIME
)
BEGIN
SELECT * FROM tbl_start_time_day WHERE start_time_day = start_time_day_par;
END // 
DELIMITER ;

/* "Sp_UpdateStartTimeDay" */
DELIMITER //
CREATE PROCEDURE sp_update_start_time_day(
    IN start_time_day_old_par TIME,
    IN start_time_day_new_par TIME
)
BEGIN
UPDATE tbl_start_time_day
SET 
	start_time_day = IFNULL(start_time_day_new_par, start_time_day)
WHERE start_time_day = start_time_day_old_par;
END // 
DELIMITER ;

/* "Sp_SelectStudentFnameLname" */
DELIMITER //
CREATE PROCEDURE sp_select_student_fname_lname(
)
BEGIN
SELECT
    tbl_students.student_id,
    tbl_first_names.first_name,
    tbl_last_names.last_name
FROM
    tbl_students
    INNER JOIN tbl_first_names 
        ON (tbl_students.student_first_name_id = tbl_first_names.first_name_id)
    INNER JOIN tbl_last_names 
        ON (tbl_students.student_last_name_id = tbl_last_names.last_name_id);
END // 
DELIMITER ;

/* "Sp_SelectStudents" */
DELIMITER //
CREATE PROCEDURE sp_select_students(
)
BEGIN
SELECT
    tbl_students.student_id, 
    tbl_first_names.first_name,
    tbl_last_names.last_name,
    tbl_dob.dob,
    tbl_genders.gender,
    tbl_emails.e_mail_address,
    tbl_student_parents_details.parent_id AS ParentID,
    tbl_student_parents_details.first_name AS Parent_FirstName,
    tbl_student_parents_details.last_name AS Parent_LastName,
    tbl_student_parents_details.phone_number AS Parent_Phone_Number,
    tbl_addresses.address_id,
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
END // 
DELIMITER ;

/* "Sp_SelectStudentsByStudentId" */
DELIMITER //
CREATE PROCEDURE sp_select_students_by_student_id(
    IN student_id_par INT
)
BEGIN
SELECT
    tbl_students.student_id, 
    tbl_first_names.first_name,
    tbl_last_names.last_name,
    tbl_dob.dob,
    tbl_genders.gender,
    tbl_emails.e_mail_address,
    tbl_student_parents_details.parent_id AS ParentID,
    tbl_student_parents_details.first_name AS Parent_FirstName,
    tbl_student_parents_details.last_name AS Parent_LastName,
    tbl_student_parents_details.phone_number AS Parent_Phone_Number,
    tbl_addresses.address_id,
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
        ON (tbl_students.student_address_home_id = tbl_addresses.address_id)
	WHERE tbl_students.student_id LIKE student_id_par;
END // 
DELIMITER ;

/* "Sp_InsertStudent" */
DELIMITER //
CREATE PROCEDURE sp_insert_student(
    IN student_first_name_id_par INT,
    IN student_last_name_id_par INT,
    IN student_dob_id_par INT,
    IN gender_id_par INT,
    IN student_e_mail_id_par INT,
    IN student_parent_id_par INT,
    IN student_address_home_id_par INT

)
BEGIN
INSERT INTO tbl_students (student_first_name_id, student_last_name_id, student_dob_id, gender_id, student_e_mail_id, student_parent_id, student_address_home_id)
SELECT * FROM (SELECT student_first_name_id_par, student_last_name_id_par, student_dob_id_par, gender_id_par, student_e_mail_id_par, student_parent_id_par, student_address_home_id_par) AS tmp
WHERE NOT EXISTS (
    SELECT student_first_name_id, student_last_name_id, student_dob_id, gender_id, student_e_mail_id, student_parent_id, student_address_home_id FROM tbl_students 
    WHERE 
	student_first_name_id = student_first_name_id_par AND
	student_last_name_id = student_last_name_id_par AND
	student_dob_id = student_dob_id_par AND
	gender_id = gender_id_par AND
	student_e_mail_id = student_e_mail_id_par AND
	student_parent_id = student_parent_id_par AND
	student_address_home_id = student_address_home_id_par
) LIMIT 1;
END // 
DELIMITER ;
/* "Sp_DeleteStudentByStudentId" */
DELIMITER //
CREATE PROCEDURE sp_delete_student_by_student_id(
    IN student_id_par INT
)
BEGIN
DELETE FROM tbl_students WHERE student_id = student_id_par;
END // 
DELIMITER ;

/* "Sp_UpdateStudent" */
DELIMITER //
CREATE PROCEDURE sp_update_student(
    IN student_id_par INT,
    IN student_first_name_id_par INT,
    IN student_last_name_id_par INT,
    IN student_dob_id_par INT,
    IN gender_id_par INT,
    IN student_e_mail_id_par INT,
    IN student_parent_id_par INT,
    IN student_address_home_id_par INT
)
BEGIN
UPDATE tbl_students
SET 
	student_first_name_id = IFNULL(student_first_name_id_par, student_first_name_id),
	student_last_name_id = IFNULL(student_last_name_id_par, student_last_name_id),
	student_dob_id = IFNULL(student_dob_id_par, student_dob_id),
	gender_id = IFNULL(gender_id_par, gender_id),
    student_e_mail_id = IFNULL(student_e_mail_id_par, student_e_mail_id),
	student_parent_id = IFNULL(student_parent_id_par, student_parent_id),
	student_address_home_id = IFNULL(student_address_home_id_par, student_address_home_id)
WHERE student_id = student_id_par;
END // 
DELIMITER ;

/* "Sp_SelectParentByFirstName" */
DELIMITER //
CREATE PROCEDURE sp_select_parent_by_first_name(
   IN parent_fname_par VARCHAR(10)
)
BEGIN
SELECT * FROM tbl_student_parents_details WHERE first_name = parent_fname_par; 
END // 
DELIMITER ;

/* "Sp_UpdateStudentParentsDetailsByParentId" */
DELIMITER //
CREATE PROCEDURE sp_update_student_parents_details_by_parent_id(
    IN parent_id_par INT,
    IN first_name_par VARCHAR(10),
    IN last_name_par VARCHAR(10),
    IN phone_number_par VARCHAR(11)
)
BEGIN
UPDATE tbl_student_parents_details
SET 
	first_name = IFNULL(first_name_par, first_name),
	last_name = IFNULL(last_name_par, last_name),
	phone_number = IFNULL(phone_number_par, phone_number)
WHERE parent_id = parent_id_par;
END // 
DELIMITER ;

/* "Sp_InsertStudentParentDetails" */
DELIMITER //
CREATE PROCEDURE sp_insert_student_parent_details(
    IN first_name_par VARCHAR(10),
    IN last_name_par VARCHAR(10),
    IN phone_number_par VARCHAR(11),
    OUT parent_id_par INT(11)
)
BEGIN
INSERT INTO tbl_student_parents_details (first_name, last_name, phone_number)
SELECT * FROM (SELECT first_name_par, last_name_par, phone_number_par) AS tmp
WHERE NOT EXISTS (
    SELECT first_name, last_name, phone_number FROM tbl_student_parents_details 
	 WHERE 
	 first_name = first_name_par AND 
	 last_name = last_name_par AND
	 phone_number = phone_number_par
) LIMIT 1;
SET parent_id_par = LAST_INSERT_ID();
END // 
DELIMITER ;

/* "Sp_SelectTeachers" */
DELIMITER //
CREATE PROCEDURE sp_select_teachers(
)
BEGIN
SELECT
    tbl_teachers.teacher_id,
    tbl_first_names.first_name,
    tbl_last_names.last_name,
    tbl_dob.dob,
    tbl_genders.gender,
    tbl_emails.e_mail_address,
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
END // 
DELIMITER ;

/* "Sp_SelectTeacherFnameLname" */
DELIMITER //
CREATE PROCEDURE sp_select_teacher_fname_lname(
)
BEGIN
SELECT
    tbl_teachers.teacher_id,
    tbl_first_names.first_name,
    tbl_last_names.last_name
FROM
    tbl_teachers
    INNER JOIN tbl_first_names 
        ON (tbl_teachers.first_name_id = tbl_first_names.first_name_id)
    INNER JOIN tbl_last_names 
        ON (tbl_teachers.last_name_id = tbl_last_names.last_name_id);
END // 
DELIMITER ;

/* "Sp_SelectTeacherById" */
DELIMITER //
CREATE PROCEDURE sp_select_teacher_by_id(
    IN teacher_id_par INT
)
BEGIN
SELECT
    tbl_teachers.teacher_id,
    tbl_first_names.first_name,
    tbl_last_names.last_name,
    tbl_dob.dob,
    tbl_genders.gender,
    tbl_emails.e_mail_address,
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
        ON (tbl_teachers.teachers_address_id = tbl_addresses.address_id)
    WHERE tbl_teachers.teacher_id = teacher_id_par;
END // 
DELIMITER ;

/* "Sp_InsertTeacher" */
DELIMITER //
CREATE PROCEDURE sp_insert_teacher(
    IN first_name_id_par INT,
    IN last_name_id_par INT,
    IN dob_id_par INT,
    IN gender_id_par INT,
    IN e_mail_id_par INT,
    IN teachers_address_id_par INT

)
BEGIN
INSERT INTO tbl_teachers (first_name_id, last_name_id, dob_id, gender_id, e_mail_id, teachers_address_id)
SELECT * FROM (SELECT first_name_id_par, last_name_id_par, dob_id_par, gender_id_par, e_mail_id_par, teachers_address_id_par) AS tmp
WHERE NOT EXISTS (
    SELECT first_name_id, last_name_id, dob_id, gender_id, e_mail_id, teachers_address_id FROM tbl_teachers
    WHERE 
	first_name_id = first_name_id_par AND
	last_name_id = last_name_id_par AND
	dob_id = dob_id_par AND
	gender_id = gender_id_par AND
	e_mail_id = e_mail_id_par AND
	teachers_address_home_id =teachers_address_home_id_par
) LIMIT 1;
END // 
DELIMITER ;

/* "Sp_DeleteTeacherByTeacherId" */
DELIMITER //
CREATE PROCEDURE sp_delete_teacher_by_teacher_id(
    IN teacher_id_par INT
)
BEGIN
DELETE FROM tbl_teachers WHERE teacher_id = teacher_id_par;
END // 
DELIMITER ;

/* "Sp_UpdateTeacherByTeacherId" */
DELIMITER //
CREATE PROCEDURE sp_update_teacher_by_teacher_id(
    IN teacher_id_par INT,
    IN first_name_id_par INT,
    IN last_name_id_par INT,
    IN dob_id_par INT,
    IN gender_id_par INT,
    IN e_mail_id_par INT,
    IN teachers_address_id_par INT
)
BEGIN
UPDATE tbl_teachers
SET 
	first_name_id = IFNULL(first_name_id_par, first_name_id),
	last_name_id = IFNULL(last_name_id_par, last_name_id),
	dob_id = IFNULL(dob_id_par, dob_id),
	gender_id = IFNULL(gender_id_par, gender_id),
	e_mail_id = IFNULL(e_mail_id_par, e_mail_id),
	teachers_address_id = IFNULL(teachers_address_id_par, teachers_address_id)
WHERE teacher_id = teacher_id_par;
END // 
DELIMITER ;

/* "Sp_SelectTeachingMaterialWithFileContentByTeachingId" */
DELIMITER //
CREATE PROCEDURE sp_select_teaching_material_with_file_content_by_teaching_id(
    IN teaching_id_par INT
)
BEGIN
SELECT
    tbl_teaching_materials.teaching_id,
    tbl_teaching_materials.file_name,
    tbl_file_extensions.file_extension,
    tbl_teaching_materials.description,
    tbl_teaching_materials.file_content,
    tbl_teachers.teacher_id,
    tbl_first_names.first_name,
    tbl_last_names.last_name
FROM
    tbl_teaching_materials
    INNER JOIN tbl_teachers 
        ON (tbl_teaching_materials.teacher_id = tbl_teachers.teacher_id)
    INNER JOIN tbl_first_names 
        ON (tbl_teachers.first_name_id = tbl_first_names.first_name_id)
    INNER JOIN tbl_last_names 
        ON (tbl_teachers.last_name_id = tbl_last_names.last_name_id)
    INNER JOIN tbl_file_extensions 
        ON (tbl_teaching_materials.file_extension_id = tbl_file_extensions.file_extension_id)
    WHERE tbl_teaching_materials.teaching_id = teaching_id;
END // 
DELIMITER ;

/* "Sp_InsertTeachingMaterial" */
DELIMITER //
CREATE PROCEDURE sp_insert_teaching_material(
    IN file_name_par VARCHAR(20),
    IN file_extension_id_par INT,
    IN description_par VARCHAR(255),
    IN file_content_par LONGBLOB,
    IN teacher_id_par INT

)
BEGIN
INSERT INTO tbl_teaching_materials (file_name, file_extension_id, description, file_content, teacher_id)
SELECT * FROM (SELECT file_name_par, file_extension_id_par, description_par, file_content_par, teacher_id_par) AS tmp
WHERE NOT EXISTS (
    SELECT file_name, file_extension_id, description, file_content, teacher_id FROM tbl_teaching_materials
    WHERE 
	file_name = file_name_par AND
	file_extension_id = file_extension_id_par AND
	description = file_content_par AND
	file_content = teacher_id_par AND
	teacher_id = teacher_id_par
) LIMIT 1;
END // 
DELIMITER ;

/* "Sp_DeleteTeachingMaterialByTeachingId" */
DELIMITER //
CREATE PROCEDURE sp_delete_teaching_material_by_teaching_id(
    IN teaching_id_par INT
)
BEGIN
DELETE FROM tbl_teaching_materials WHERE teaching_id = teaching_id_par;
END // 
DELIMITER ;

/* "Sp_SelectTimeTableByClassroomName" */
DELIMITER //
CREATE PROCEDURE sp_select_time_table_by_classroom_name(
    IN classroom_par VARCHAR(10)
)
BEGIN
SELECT
	tbl_classes.class_id,
	tbl_days.day,
	tbl_start_time_day.start_time_day,
    tbl_end_time_day.end_time_day,
    tbl_classrooms.classroom,
	tbl_first_names.first_name AS Teacher_FName,
	tbl_last_names.last_name AS Teacher_LName, 
	tbl_classes.subject,
	tbl_teachers.teacher_id,
	tbl_days.day_id
FROM
    tbl_classes
    INNER JOIN tbl_teachers 
        ON (tbl_classes.teacher_id = tbl_teachers.teacher_id)
    INNER JOIN tbl_classrooms 
        ON (tbl_classes.classroom_id = tbl_classrooms.classroom_id)
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
	WHERE tbl_classrooms.classroom LIKE classroom_par;
END // 
DELIMITER ;
/* "Sp_InsertClasses" */
DELIMITER //
CREATE PROCEDURE sp_insert_classes(
    IN classroom_id_par INT,
    IN subject_par VARCHAR(30),
    IN teacher_id_par INT,
    IN start_time_day_id_par INT,
    IN end_time_day_id_par INT,
    IN day_id_par INT)
BEGIN
INSERT INTO tbl_classes (classroom_id, subject, teacher_id, start_time_day_id,end_time_day_id, day_id) VALUES 
(classroom_id_par, subject_par, teacher_id_par, start_time_day_id_par, end_time_day_id_par, day_id_par);
END // 
DELIMITER ;

/* "Sp_DeleteTimetable" */
DELIMITER //
CREATE PROCEDURE sp_delete_timetable(
    IN class_id_par INT
)
BEGIN
DELETE FROM tbl_classes WHERE class_id = class_id_par;
END //
DELIMITER ;

/* "Sp_UpdateTimetable" */
DELIMITER //
CREATE PROCEDURE sp_update_timetable(
    IN class_id_par INT,
    IN classroom_id_par INT,
    IN subject_par VARCHAR(30),
    IN teacher_id_par INT,
    IN start_time_day_id_par INT,
    IN end_time_day_id_par INT,
    IN day_id_par INT
)
BEGIN
UPDATE tbl_classes
SET 
	classroom_id = IFNULL(classroom_id_par, classroom_id),
	subject = IFNULL(subject_par, subject),
	teacher_id = IFNULL(teacher_id_par, teacher_id),
	start_time_day_id = IFNULL(start_time_day_id_par, start_time_day_id),
	end_time_day_id = IFNULL(end_time_day_id_par, end_time_day_id),
	day_id = IFNULL(day_id_par, day_id)
WHERE class_id = class_id_par;
END // 
DELIMITER ;

/* "Sp_SelectTimeTable" */
DELIMITER //
CREATE PROCEDURE sp_select_time_table(
)

BEGIN
SELECT
	tbl_classes.class_id,
	tbl_days.day,
	tbl_start_time_day.start_time_day,
    tbl_end_time_day.end_time_day,
    tbl_classrooms.classroom,
	tbl_first_names.first_name AS Teacher_FName,
	tbl_last_names.last_name AS Teacher_LName, 
	tbl_classes.subject,
	tbl_teachers.teacher_id,
	tbl_days.day_id
FROM
    tbl_classes
    INNER JOIN tbl_teachers 
        ON (tbl_classes.teacher_id = tbl_teachers.teacher_id)
    INNER JOIN tbl_classrooms 
        ON (tbl_classes.classroom_id = tbl_classrooms.classroom_id)
    INNER JOIN tbl_start_time_day 
        ON (tbl_classes.start_time_day_id = tbl_start_time_day.start_time_day_id)
    INNER JOIN tbl_end_time_day 
        ON (tbl_classes.end_time_day_id = tbl_end_time_day.end_time_day_id)
    INNER JOIN tbl_first_names 
        ON (tbl_teachers.first_name_Id = tbl_first_names.first_name_id)
    INNER JOIN tbl_last_names 
        ON (tbl_teachers.last_name_Id = tbl_last_names.last_name_id)
    INNER JOIN tbl_days 
        ON (tbl_classes.day_id = tbl_days.day_id);
END // 
DELIMITER ;

/* "Sp_SelectTeachingMaterial" */
DELIMITER //
CREATE PROCEDURE sp_select_teaching_material(
)
BEGIN
SELECT
    tbl_teaching_materials.teaching_id,
    tbl_teaching_materials.file_name,
    tbl_file_extensions.file_extension,
    tbl_teaching_materials.description,
    tbl_teachers.teacher_id,
    tbl_first_names.first_name,
    tbl_last_names.last_name
FROM
    tbl_teaching_materials
    INNER JOIN tbl_teachers 
        ON (tbl_teaching_materials.teacher_id = tbl_teachers.teacher_id)
    INNER JOIN tbl_first_names 
        ON (tbl_teachers.first_name_id = tbl_first_names.first_name_id)
    INNER JOIN tbl_last_names 
        ON (tbl_teachers.last_name_id = tbl_last_names.last_name_id)
    INNER JOIN tbl_file_extensions 
        ON (tbl_teaching_materials.file_extension_id = tbl_file_extensions.file_extension_id);
END // 
DELIMITER ;
