var testStudents = '{"students": [{"id": "asdf", "email": "asdf@gmail.com"}, {"id": "qwer", "email": "qwer@gmail.com"}, {"id": "zxcv", "email": "zxcv@gmail.com"}, {"id": "cvbn", "email": "cvbn@gmail.com"}, {"id": "dfgh", "email": "dfgh@gmail.com"}]}';

function getStudents() {
    return JSON.parse(testStudents);
}

function populateStudentTable() {
    var data = getStudents();
    displayStudents(data.students);
}

function displayStudents(students) {
    var tableList = "";
    for (var i = 0; i < students.length; i++) {
        tableList += "<tr><td>" + students[i].id + "</td><td>" + students[i].email + "</td></tr>";
        document.getElementById("student-list").innerHTML = tableList;
    }
}