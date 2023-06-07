package kr.ac.kopo.springlearning.repository;

import kr.ac.kopo.springlearning.domain.Student;
import org.springframework.data.jpa.repository.JpaRepository;

public interface StudentRepository extends JpaRepository <Student, Integer> {
}
