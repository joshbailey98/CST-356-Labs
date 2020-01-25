function validate() {
    let username = document.getElementById('username').value
    let password = document.getElementById('password').value

    if (username == '' && password == '') {
        document.getElementById('error').innerText = "Error: Username and password cannot be blank.";
    }
    else if (username == '') {
        document.getElementById('error').innerText = "Error: Username cannot be blank.";
    }
    else if (password == '') {
        document.getElementById('error').innerText = "Error: Password cannot be blank.";
    }
    else document.getElementById('error').innerText = "";
}