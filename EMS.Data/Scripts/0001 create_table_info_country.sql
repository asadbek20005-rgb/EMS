create Table if not exists info.info_country
(
    id    SERIAL PRIMARY KEY,
    code  VARCHAR(10),
    short_name VARCHAR(10),
    full_name  VARCHAR(50),
    
    created_date TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
    updated_date TIMESTAMP without TIME ZONE
);


select *from info.info_country;

