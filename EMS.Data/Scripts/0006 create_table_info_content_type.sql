create Table if not exists info.info_content_type
(
    id    SERIAL PRIMARY KEY,
    short_name VARCHAR(10) NOT NULL, --excel ,img
    full_name  VARCHAR(50) NOT NULL, --application/vnd.openxmlformats-officedocument.spreadsheetml.sheet,png/
    type_name varchar(100) not null,
    created_date TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
    updated_date TIMESTAMP without TIME ZONE
);