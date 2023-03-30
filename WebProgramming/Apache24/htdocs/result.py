#!python

import cgi;
import cgitb;
import os
cgitb.enable();
 
# get,post 구분없이 데이터를 가져온다.
form = cgi.FieldStorage();
a = form.getvalue('a');
b = form.getvalue('b');

if os.environ['REQUEST_METHOD'] == 'GET':
    req_method = 'GET'
else:
    req_method = 'POST'

#args = cgi.parse()
 
html = f"""
<!DOCTYPE html>
<html>
  <head><title>RESULT</title></head>
  <body>
    <div>METHOD : {req_method}</div>
    <div>FIELD A : {a}</div>
    <div>FIELD B : {b}</div>
  </body>
</html>
""";
 
print("content-type:text/html; charset=UTF-8\n")
print(html);
