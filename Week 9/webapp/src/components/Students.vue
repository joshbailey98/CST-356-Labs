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
            <tr v-for="student in students" v-bind:key="student.studentId">
                <td>{{ student.studentId }}</td>
                <td>{{ student.emailAddress }}</td>
            </tr>
        </tbody>
    </table>
</div>
</template>

<script>
    import Vue from 'vue';
    export default {
        name: 'Students',
        
        data () {
            return {
                students: [],
                operation: 'list',
                studentId: undefined,
                emailAddress: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },
        methods: {
            getStudents: async function() {
                let url = `http://${this.apiServer}/api/student`;
                const jwtToken  = await this.$auth.getTokenSilently();
                await Vue.axios.get(url, {
                    headers: {
                        Authorization: `Bearer ${jwtToken}`
                    }
                }).then(
                    (response) => {
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            }
        },
        mounted() {
            this.getStudents();
            this.operation = 'list';
        }
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
