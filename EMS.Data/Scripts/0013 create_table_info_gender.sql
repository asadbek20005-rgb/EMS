    create Table info.info_gender
    (
        id SERIAL PRIMARY KEY,
        short_name VARCHAR(10) NOT NULL, --max count if rows always 2
        full_name  VARCHAR(50) NOT NULL, 
        created_date TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
        updated_date TIMESTAMP without TIME ZONE
    );
