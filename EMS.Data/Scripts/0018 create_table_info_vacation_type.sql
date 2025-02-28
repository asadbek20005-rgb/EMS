    create TABLE my.info_vacation_type
    (
        id SERIAL PRIMARY KEY,
        code  VARCHAR(10), 
        short_name VARCHAR(10) NOT NULL, --general
        full_name  VARCHAR(50) NOT NULL, 
        duration   VARCHAR(50) NOT NULL,
        status_id INTEGER not NULL REFERENCES my.info_vacation_status(id),
        created_date TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
        updated_date TIMESTAMP without TIME ZONE
    );