create table info.info_contract_type
(
    id SERIAL PRIMARY KEY,
    user_id UUID NOT NULL REFERENCES my.sys_user(id),
    status BOOLEAN DEFAULT TRUE,
    created_date TIMESTAMP WITHOUT TIME ZONE DEFAULT current_TIMESTAMP,
    updated_date TIMESTAMP WITHOUT TIME ZONE
)