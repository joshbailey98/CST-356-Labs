var testInstructors = '{"instructors": [{"first": "Jill", "middle": "R.", "last": "Smith"}, {"first": "Michael", "middle": "B.", "last": "James"}, {"first": "Tom", "middle": "D.", "last": "Brown"}, {"first": "Bob", "middle": "K.", "last": "Roberts"}, {"first": "Sarah", "middle": "M.", "last": "Jane"}]}';

function getInstructors() {
    return JSON.parse(testInstructors);
}

function populateInstructorTable() {
    var data = getInstructors();
    displayInstructors(data.instructors);
}

function displayInstructors(instructors) {
    var tableList = "";
    for (var i = 0; i < instructors.length; i++) {
        tableList += "<tr><td>" + instructors[i].first + "</td><td>" + instructors[i].middle + "</td><td>" + instructors[i].last + "</td></tr>";
        document.getElementById("instructor-list").innerHTML = tableList;
    }
}