package kr.ac.kopo.springlearning.domain;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import lombok.Builder;
import lombok.Getter;
import lombok.Setter;
import org.hibernate.annotations.CreationTimestamp;

import java.sql.Timestamp;

@Entity

//롬복이 알아서 게터랑 세터 만들어줌ㅇㅇ
@Getter
@Setter
public class Student {

    public Student(){};
    @Builder
    public Student(String name, int age, int grade)
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)

    private int seq;
    private String name;
    private int age;
    private int grade;

    @CreationTimestamp
    private Timestamp createData;
}
