package kr.ac.kopo.springlearning.service;


import kr.ac.kopo.springlearning.domain.Student;
import kr.ac.kopo.springlearning.repository.StudentRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Example;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.domain.Sort;
import org.springframework.data.repository.query.FluentQuery;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;
import java.util.function.Function;

@Service
public class StudentService {

    // 편의상 Auto wired
    // 이게 지침
    // private StudentRepository studentRepository;

    // StudentService(StudentRepository studentRepository)
    // {
    //     this.studentRepository = studentRepository;
    // }

    @Autowired
    StudentRepository studentRepository;


    public Student insert(String name, int age, int grade){

        Student student = Student.builder()
                .name(name)
                .age(age)
                .grade(grade)
                .build();

        return studentRepository.save(student);
    }

    public List<Student> select()
    {
        return studentRepository.findAll();
    }

    public Student delete(int seq)
    {
        Student student = studentRepository.findById(seq).get();
        studentRepository.delete(student);

        return student;
    }
}
