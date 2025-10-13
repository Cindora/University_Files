
CREATE TABLE shedule.Audit (
                audit_number INTEGER NOT NULL,
                corps_number INTEGER NOT NULL,
                floor INTEGER NOT NULL,
                CONSTRAINT audit_pk PRIMARY KEY (audit_number)
);
COMMENT ON COLUMN shedule.Audit.audit_number IS 'Номер аудитории';


CREATE SEQUENCE shedule.class_seq;

CREATE TABLE shedule.Class (
                class_id INTEGER NOT NULL DEFAULT nextval('shedule.class_seq'),
                week_day VARCHAR(20) NOT NULL,
                pair_number INTEGER NOT NULL,
                group_number VARCHAR(30) NOT NULL,
                subject VARCHAR(70) NOT NULL,
                lesson_type VARCHAR(20) DEFAULT лекция NOT NULL,
                capacity INTEGER DEFAULT 30 NOT NULL,
                students_number INTEGER DEFAULT 0 NOT NULL,
                audit_number INTEGER NOT NULL,
                CONSTRAINT class_pk PRIMARY KEY (class_id)
);
COMMENT ON COLUMN shedule.Class.class_id IS 'Идентификатор занятия';
COMMENT ON COLUMN shedule.Class.audit_number IS 'Номер аудитории';


ALTER SEQUENCE shedule.class_seq OWNED BY shedule.Class.class_id;

ALTER TABLE shedule.Class ADD CONSTRAINT audit_class_fk
FOREIGN KEY (audit_number)
REFERENCES shedule.Audit (audit_number)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;
