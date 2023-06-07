package kr.ac.kopo.springlearning.controller;

import kr.ac.kopo.springlearning.domain.Student;
import kr.ac.kopo.springlearning.service.StudentService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.stereotype.Repository;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.ResponseBody;

import java.util.List;

@Controller
public class CommonController {
    @Autowired
    StudentService studentService;

    @GetMapping("user")
    String user()
    {
        return "/user";
    }

    @GetMapping("/student/insert/{name}/{age}/{grade}")
    @ResponseBody
    Student insert(
            @PathVariable("name") String name,
            @PathVariable("age") int age,
            @PathVariable("grade") int grade)
    {
        return studentService.insert(name, age, grade);
    }

    @GetMapping("/student/select")
    @ResponseBody
    List<Student> select()
    {
        return studentService.select();
    }

    @GetMapping("/student/delete/{seq}")
    @ResponseBody
    Student delete(@PathVariable("seq") int seq)
    {
        return studentService.delete(seq);
    }
}
