import models.Students;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Sort;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import repositories.StudentsRepository;

import java.util.List;

@RestController
@RequestMapping("/")
@CrossOrigin("*")
public class Controller {
    @Autowired
    StudentsRepository studentsRepository;

    @GetMapping("/students")
    public List<Students> getAllStudents(){
        Sort sortByCreatedAtDesc = new Sort(Sort.Direction.DESC, "createdAt");
        return studentsRepository.findAll(sortByCreatedAtDesc);
    }

}
