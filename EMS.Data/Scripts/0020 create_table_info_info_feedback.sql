create table if not exists info.info_feedback_type
(
    id serial primary key,
    text TEXT NULL,
    is_read boolean default false,
    created_date TIMESTAMP WITHOUT TIME ZONE DEFAULT current_TIMESTAMP,
    updated_date TIMESTAMP WITHOUT TIME ZONE
)