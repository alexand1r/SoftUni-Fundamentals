package app.repositories;

public interface UserRepository
        extends JpaRepository<User, Long> {
    List<User> findByUsername(String username);
}
