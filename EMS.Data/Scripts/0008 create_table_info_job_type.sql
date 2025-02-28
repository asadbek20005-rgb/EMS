CREATE TABLE info.info_job_type
(
    id SERIAL PRIMARY KEY,
    code  VARCHAR(10),
    short_name VARCHAR(10) NOT NULL,
    full_name  VARCHAR(50) NOT NULL,

    
    created_date TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
    updated_date TIMESTAMP without TIME ZONE
);