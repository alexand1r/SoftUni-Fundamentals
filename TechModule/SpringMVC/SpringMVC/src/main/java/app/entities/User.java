package app.entities;

import org.springframework.data.annotation.Id;

@Entity @Table(name = "users")
public class User {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @Column(nullable = false, length = 30, unique = true)
    private String username;
    @Column(length = 60)
    private String passwordHash;
    @Column(length = 100)
    private String fullName;
}
