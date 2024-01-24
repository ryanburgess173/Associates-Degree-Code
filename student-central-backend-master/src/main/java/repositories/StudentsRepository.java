package repositories;

import models.Students;
import org.springframework.data.mongodb.repository.MongoRepository;

public interface StudentsRepository extends MongoRepository<Students, String> {
}
