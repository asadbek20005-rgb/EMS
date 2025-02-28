CREATE TABLE info.info_task_result
(
    id SERIAL PRIMARY KEY,
    task_id INTEGER NOT NULL,
    user_id INTEGER NOT NULL,
    result_type_id INTEGER NOT NULL REFERENCES info.info_task_result_type,
    result_description TEXT NULL,
    result_url TEXT NULL,
    is_active BOOLEAN DEFAULT TRUE,

    created_ad TIMESTAMP WITHOUT TIME ZONE DEFAULT current_TIMESTAMP,
    updated_ad TIMESTAMP WITHOUT TIME ZONE
);