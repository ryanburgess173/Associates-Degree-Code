package models;

import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.Document;

@Document(collection="Students")
public class Students {

    @Id
    private String id;

    private String firstName;
    private String lastName;
    private int age;
    private double gpa;
    private String phone;
    private String cell;
    private String email;
}
