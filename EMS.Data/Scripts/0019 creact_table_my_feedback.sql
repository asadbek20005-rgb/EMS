CREATE TABLE if not exists my.feedback
(
    id SERIAL PRIMARY KEY,
    from_user_id UUID NOT NULL REFERENCES my.sys_user(id),
    to_user_id UUID NOT NULL REFERENCES my.sys_user(id),
    feedback_type_id INTEGER NOT NULL REFERENCES info.info_feedback_type(id),

    created_date TIMESTAMP WITHOUT TIME ZONE DEFAULT current_TIMESTAMP,
    updated_date TIMESTAMP WITHOUT TIME ZONE
);
