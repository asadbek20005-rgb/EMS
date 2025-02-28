
CREATE TABLE info.info_work_time --Back-Junior => 25h/week
(
    id SERIAL PRIMARY KEY,
    code  VARCHAR(10),
    short_name      VARCHAR(10) NOT NULL, -- short_type_name - short-level_name
    full_name       VARCHAR(50) NOT NULL, -- full_type_name - full-level_name
    job_type_id     INTEGER not NULL REFERENCES info.info_job_type(id), --1(mobile)
    job_level_id    INTEGER NOT NULL REFERENCES  info.info_job_level(id), --2(middile)
    details         varchar(100) NOT NUll,
    per_week_amount INTEGER not NULL,
    created_date    TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
    updated_date    TIMESTAMP without TIME ZONE
);
