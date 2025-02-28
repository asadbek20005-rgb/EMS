CREATE TABLE info.info_task_result_type
(
    id SERIAL PRIMARY KEY,
    name VARCHAR(50) UNIQUE NOT NULL,
    description TEXT NULL,
    is_active BOOLEAN DEFAULT TRUE,

    created_ad TIMESTAMP WITHOUT TIME ZONE DEFAULT current_TIMESTAMP,
    updated_ad TIMESTAMP WITHOUT TIME ZONE
);