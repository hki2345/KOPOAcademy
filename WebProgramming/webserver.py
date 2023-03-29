from bottle import route, run, request, get, post, error, static_file

# Static Routes  ##################################################
@route("/static/<filepath:re:.*\.*>")
def css(filepath):
    return static_file(filepath, root="static")


# Dynamic Routes  ##################################################
@route('/hello')
def hello():
    return "Hello World!"

@get('/msg')
def message():
    name = request.query.name
    age = request.query.age
    return "{0} is {1} years old".format(name, age)

@post('/result') # or @route('/result', method='POST')
def post_result():
    a = request.forms.a 
    b = request.forms.b 
    return '''
    <div>METHOD : POST</div>
    <div>FIELD A : {0}</div>
    <div>FIELD B : {1}</div>
    '''.format(a, b)
    
@get('/result') # or @route('/result', method='GET')
def get_result():
    a = request.query.get('a') 
    b = request.query.get('b')
    return '''
    <div>METHOD : GET</div>
    <div>FIELD A : {0}</div>
    <div>FIELD B : {1}</div>
    '''.format(a, b)


run(host='localhost', port=80, debug=True)
