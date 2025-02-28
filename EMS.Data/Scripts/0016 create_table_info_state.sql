
    CREATE Table info.info_state
    (
        id SERIAL PRIMARY KEY,
        short_name VARCHAR(10) NOT NULL, --active and passive
        full_name  VARCHAR(50) NOT NULL, --
        created_date TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
        updated_date TIMESTAMP without TIME ZONE
    );