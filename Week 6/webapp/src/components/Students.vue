<template>
<div>
    <br />
    <table>
        <thead>
            <tr>
                <th class="heading" colspan="2">Students</th>
            </tr>
            <tr>
                <th>Student ID</th>
                <th>Email Address</th>
            </tr>
        </thead>
        <tbody id="student-list">
            <tr v-for="student in students" v-bind:key="student">
                <td>{{ student.id }}</td>
                <td>{{ student.email }}</td>
            </tr>
        </tbody>
    </table>
</div>
</template>

<script>
    export default {
        name: 'Students',
        mounted() {
            this.students = getStudents();
        },
        data () {
            return {
                students: []
            }
        }
    }
    function getStudents() {
        return JSON.parse(students);
    }
    var students = '[{"id": "asdf", "email": "asdf@gmail.com"}, {"id": "qwer", "email": "qwer@gmail.com"}, {"id": "zxcv", "email": "zxcv@gmail.com"}, {"id": "cvbn", "email": "cvbn@gmail.com"}, {"id": "dfgh", "email": "dfgh@gmail.com"}]';
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
