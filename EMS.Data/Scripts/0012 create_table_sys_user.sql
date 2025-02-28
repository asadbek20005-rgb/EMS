   CREATE Table my.sys_user
    (
        id UUID NOT NULL PRIMARY KEY,
        first_name VARCHAR(30) NOT NULL,
        last_name  VARCHAR(30) NOT NULL,
        full_name  VARCHAR(30) NOT NULL,
        username   VARCHAR(32) NOT NULL UNIQUE,
        password_hash TEXT NOT NULL,
        phone_number VARCHAR(15),
        date_of_birth  DATE NULL,
        role_id     INTEGER not NULL REFERENCES info.info_role(id),
        gender_id   INTEGER not NULL REFERENCES info.info_gender(id), 
        content_id INTEGER NULL REFERENCES info.info_content(id),
        state_id    INTEGER NOT NULL REFERENCES info.info_state(id),
        created_date TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
        created_user_id UUID NOT NULL,
        updated_date TIMESTAMP without TIME ZONE,
        modified_user_id UUID  NULL
    );