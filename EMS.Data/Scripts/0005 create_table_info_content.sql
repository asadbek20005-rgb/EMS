create Table if not exists info.info_content
(
    id    SERIAL PRIMARY KEY, 
    name  VARCHAR(10),
    file_url TEXT not NULL,   --(asdg-asdj-wewe-sdawe)--photo

    task_id INTEGER NULL  REFERENCES my.task(id),

    content_type_id INTEGER NOT NULL REFERENCES info.info_content_type(id), --2,png
    created_date TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
    updated_date TIMESTAMP without TIME ZONE
);