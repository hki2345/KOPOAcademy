package kr.ac.kopo.springlearning.service;

import kr.ac.kopo.springlearning.domain.Student;
import kr.ac.kopo.springlearning.repository.StudentRepository;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;

import static org.junit.jupiter.api.Assertions.*;

class StudentServiceTest {

    @Test
    void insert(){

        Student student = Student.builder()
                .name("철수")
                .age(10)
                .grade(3)
                .build();

        System.out.println(student);
        System.out.println(student.getName());
        System.out.println(student.getAge());
        System.out.println(student.getGrade());

    }
}