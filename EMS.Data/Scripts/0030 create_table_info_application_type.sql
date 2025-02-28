
create table info.info_application_type(
    id SERIAL PRIMARY KEY,
    code  VARCHAR(10),
    short_name VARCHAR(10) NOT NULL, 
    full_name  VARCHAR(50) NOT NULL,
    is_active boolean DEFAULT true,
    type_code VARCHAR(20) UNIQUE not NULL,
    created_date TIMESTAMP WITHOUT TIME ZONE DEFAULT CURRENT_TIMESTAMP,
    updated_date TIMESTAMP WITHOUT TIME ZONE
)
