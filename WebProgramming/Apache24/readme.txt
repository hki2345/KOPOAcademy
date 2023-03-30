서버 실행 파일 -> Apache\bin\httpd.exe

서버 수정 -> Apache\conf\httpd.conf -> 파일 내 251 ~ 281 DocumentRoot "${SRVROOT}/htdocs, Directory 부분

<Files "*.py">
        Options +ExecCGI
        AddHandler cgi-script .py
</Files>

-> 서버에서 파이썬 파일을 html로 띄워주는 역할

파일 경로 -> Apache\htdoc

여기에 폴더 잡아줌 기본적으로 'Index.html'