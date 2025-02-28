
CREATE TABLE info.info_salary --Back-Junior => 400$
(
    id SERIAL PRIMARY KEY,
    code  VARCHAR(10),
    short_name VARCHAR(10) NOT NULL, -- short_type_name - short-level_name
    full_name  VARCHAR(50) NOT NULL, -- full_type_name - full-level_name
    job_type_id     INTEGER not NULL REFERENCES info.info_job_type(id), --1(mobile)
    job_level_id   INTEGER NOT NULL REFERENCES  info.info_job_level(id), --2(middile)
    amount         DECIMAL(18,2) NOT NUll,
    created_date TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
    updated_date TIMESTAMP without TIME ZONE
);