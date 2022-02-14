CREATE TABLE tbl_addresses (
  address_id INT(11) NOT NULL AUTO_INCREMENT,
  address_street VARCHAR(60) NOT NULL,
  address_city VARCHAR(30) NOT NULL,
  address_region VARCHAR(30) NOT NULL,
  address_postcode VARCHAR(10) NOT NULL,
  PRIMARY KEY (address_id)
);

CREATE TABLE tbl_classes (
  class_id INT(11) NOT NULL AUTO_INCREMENT,
  classroom_id INT(11) NOT NULL,
  subject VARCHAR(30) NOT NULL,
  teacher_id INT(11) NOT NULL,
  start_time_day_id INT(11) NOT NULL,
  end_time_day_id INT(11) NOT NULL,
  day_id INT(11) NOT NULL,
  PRIMARY KEY (class_id)
);

CREATE TABLE tbl_classrooms (
  classroom_id INT(11) NOT NULL AUTO_INCREMENT,
  classroom VARCHAR(10) NOT NULL,
  PRIMARY KEY (classroom_id)
);

CREATE TABLE tbl_date_end (
  date_end_id INT(11) NOT NULL AUTO_INCREMENT,
  date_end DATE NOT NULL,
  PRIMARY KEY (date_end_id)
);

CREATE TABLE tbl_date_start (
  date_start_id INT(11) NOT NULL AUTO_INCREMENT,
  date_start DATE NOT NULL,
  PRIMARY KEY (date_start_id)
);

CREATE TABLE tbl_days (
  day_id INT(11) NOT NULL AUTO_INCREMENT,
  day VARCHAR(10) NOT NULL,
  PRIMARY KEY (day_id)
);

CREATE TABLE tbl_dob (
  dob_id INT(11) NOT NULL AUTO_INCREMENT,
  dob DATE NOT NULL,
  PRIMARY KEY (dob_id)
);

CREATE TABLE tbl_emails (
  e_mail_id INT(11) NOT NULL AUTO_INCREMENT,
  e_mail_address VARCHAR(255) NOT NULL,
  PRIMARY KEY (e_mail_id)
);

CREATE TABLE tbl_end_time_day (
  end_time_day_id INT(11) NOT NULL AUTO_INCREMENT,
  end_time_day time NOT NULL,
  PRIMARY KEY (end_time_day_id)
);

CREATE TABLE tbl_enrolments (
  student_id INT(11) NOT NULL,
  class_id INT(11) NOT NULL,
  date_start_id INT(11) NOT NULL,
  date_end_id INT(11) NOT NULL
);

CREATE TABLE tbl_file_extensions (
  file_extension_id INT(11) NOT NULL AUTO_INCREMENT,
  file_extension VARCHAR(6) NOT NULL,
  PRIMARY KEY (file_extension_id)
);

CREATE TABLE tbl_first_names (
  first_name_id INT(11) NOT NULL AUTO_INCREMENT,
  first_names VARCHAR(10) NOT NULL,
  PRIMARY KEY (first_name_id)
);

CREATE TABLE tbl_genders (
  gender_id INT(11) NOT NULL AUTO_INCREMENT,
  gender VARCHAR(6) NOT NULL,
  PRIMARY KEY (gender_id)
);

CREATE TABLE tbl_last_names (
  last_name_id INT(11) NOT NULL AUTO_INCREMENT,
  last_name VARCHAR(10) NOT NULL,
  PRIMARY KEY (last_name_id)
);

CREATE TABLE tbl_start_time_day (
  start_time_day_id INT(11) NOT NULL AUTO_INCREMENT,
  start_time_day time NOT NULL,
  PRIMARY KEY (start_time_day_id)
);

CREATE TABLE tbl_student_parents_details (
  parent_id INT(11) NOT NULL AUTO_INCREMENT,
  first_name VARCHAR(10) NOT NULL,
  last_name VARCHAR(10) NOT NULL,
  phone_number VARCHAR(11) NOT NULL,
  PRIMARY KEY (parent_id)
);

CREATE TABLE tbl_students (
  student_id INT(11) NOT NULL AUTO_INCREMENT,
  student_first_name_id INT(11) NOT NULL,
  student_last_name_id INT(11) NOT NULL,
  student_dob_id INT(11) NOT NULL,
  gender_id INT(11) NOT NULL,
  student_picture varbinary(255) NOT NULL,
  student_e_mail_id INT(11) NOT NULL,
  student_parent_id INT(11) NOT NULL,
  student_address_home_id INT(11) NOT NULL,
  PRIMARY KEY (student_id)
);

CREATE TABLE tbl_teachers (
  teacher_id INT(11) NOT NULL AUTO_INCREMENT,
  first_name_id INT(11) NOT NULL,
  last_name_id INT(11) NOT NULL,
  dob_id INT(11) NOT NULL,
  gender_id INT(11) NOT NULL,
  e_mail_id INT(11) NOT NULL,
  payroll_nr INT(11) NOT NULL,
  teachers_address_id INT(11) NOT NULL,
  PRIMARY KEY (teacher_id)
);

CREATE TABLE tbl_teaching_materials (
  teaching_id INT(11) NOT NULL AUTO_INCREMENT,
  file_name VARCHAR(20) NOT NULL,
  file_extension_id INT(11) NOT NULL,
  description VARCHAR(255) NOT NULL DEFAULT '',
  file_content varbinary(255) NOT NULL DEFAULT '',
  teacher_id INT(11) NOT NULL,
  PRIMARY KEY (teaching_id)
);

ALTER TABLE tbl_classes 
  ADD KEY classroom_id1 (classroom_id),
  ADD KEY start_time_id (start_time_day_id),
  ADD KEY end_time_id (end_time_day_id),
  ADD KEY day_id (day_id),
  ADD KEY teacher_id_2 (teacher_id),
  ADD CONSTRAINT classroom_id1 FOREIGN KEY (classroom_id) REFERENCES tbl_classrooms (classroom_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT day_id FOREIGN KEY (day_id) REFERENCES tbl_days (day_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT end_time_id FOREIGN KEY (end_time_day_id) REFERENCES tbl_end_time_day (end_time_day_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT start_time_id FOREIGN KEY (start_time_day_id) REFERENCES tbl_start_time_day (start_time_day_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT teacher_id_2 FOREIGN KEY (teacher_id) REFERENCES tbl_teachers (teacher_id) ON UPDATE CASCADE ON DELETE NO ACTION;
  
ALTER TABLE tbl_enrolments
  ADD KEY student_id_2 (student_id),
  ADD KEY class_id (class_id),
  ADD KEY date_start_id (date_start_id),
  ADD KEY date_end_id (date_end_id),
  ADD CONSTRAINT class_id FOREIGN KEY (class_id) REFERENCES tbl_classes (class_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT date_end_id FOREIGN KEY (date_end_id) REFERENCES tbl_date_end (date_end_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT date_start_id FOREIGN KEY (date_start_id) REFERENCES tbl_date_start (date_start_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT student_id_2 FOREIGN KEY (student_id) REFERENCES tbl_students (student_id) ON UPDATE CASCADE ON DELETE NO ACTION;
  
ALTER TABLE tbl_students
  ADD KEY student_first_name_id (student_first_name_id),
  ADD KEY student_last_name_id (student_last_name_id),
  ADD KEY student_dob_id (student_dob_id),
  ADD KEY gender_id (gender_id),
  ADD KEY student_e_mail_id (student_e_mail_id),
  ADD KEY student_address_home_id (student_address_home_id),
  ADD KEY student_parent_id (student_parent_id),
  ADD CONSTRAINT gender_id FOREIGN KEY (gender_id) REFERENCES tbl_genders (gender_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT student_address_home_id FOREIGN KEY (student_address_home_id) REFERENCES tbl_addresses (address_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT student_dob_id FOREIGN KEY (student_dob_id) REFERENCES tbl_dob (dob_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT student_e_mail_id FOREIGN KEY (student_e_mail_id) REFERENCES tbl_emails (e_mail_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT student_first_name_id FOREIGN KEY (student_first_name_id) REFERENCES tbl_first_names (first_name_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT student_last_name_id FOREIGN KEY (student_last_name_id) REFERENCES tbl_last_names (last_name_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT student_parent_id FOREIGN KEY (student_parent_id) REFERENCES tbl_student_parents_details (parent_id) ON UPDATE CASCADE ON DELETE NO ACTION;

ALTER TABLE tbl_teachers
  ADD KEY first_name_id1 (first_name_Id),
  ADD KEY last_name_id1 (last_name_Id),
  ADD KEY dob_id1 (dob_id),
  ADD KEY gender_id1 (gender_Id),
  ADD KEY e_mail_id1 (e_mail_id),
  ADD KEY teachers_address_id (teachers_address_id),
  ADD CONSTRAINT dob_id1 FOREIGN KEY (dob_id) REFERENCES tbl_dob (dob_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT e_mail_id1 FOREIGN KEY (e_mail_id) REFERENCES tbl_emails (e_mail_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT first_name_id1 FOREIGN KEY (first_name_Id) REFERENCES tbl_first_names (first_name_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT gender_id1 FOREIGN KEY (gender_Id) REFERENCES tbl_genders (gender_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT last_name_id1 FOREIGN KEY (last_name_Id) REFERENCES tbl_last_names (last_name_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT teachers_address_id FOREIGN KEY (teachers_address_id) REFERENCES tbl_addresses (address_id) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE tbl_teaching_materials
  ADD KEY file_extension_id (file_extension_id),
  ADD KEY teacher_id_1 (teacher_id),
  ADD CONSTRAINT file_extension_id FOREIGN KEY (file_extension_id) REFERENCES tbl_file_extensions (file_extension_id) ON UPDATE CASCADE ON DELETE NO ACTION,
  ADD CONSTRAINT teacher_id_1 FOREIGN KEY (teacher_id) REFERENCES tbl_teachers (teacher_id) ON UPDATE CASCADE ON DELETE NO ACTION;