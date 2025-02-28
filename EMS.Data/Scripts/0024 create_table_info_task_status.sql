CREATE TABLE info.info_task_status
(
    id SERIAL PRIMARY KEY,
    user_id UUID NOT NULL, 
    task_name VARCHAR(100) NOT NULL,
    task_url TEXT NULL,
    status VARCHAR(50) NOT NULL,
    description TEXT NULL,
    is_active BOOLEAN DEFAULT TRUE,

    created_ad TIMESTAMP WITHOUT TIME ZONE DEFAULT current_TIMESTAMP,
    updated_ad TIMESTAMP WITHOUT TIME ZONE
);