<template>
<div>
    <br />
    <table>
        <thead>
            <tr>
                <th class="heading" colspan="3">Instructors</th>
            </tr>
            <tr>
              <th>First Name</th>
              <th>Middle Initial</th>
              <th>Last Name</th>
            </tr>
        </thead>
        <tbody id="instructor-list">
            <tr v-for="instructor in instructors" v-bind:key="instructor">
                <td>{{ instructor.first }}</td>
                <td>{{ instructor.middle }}</td>
                <td>{{ instructor.last }}</td>
            </tr>
        </tbody>
      </table>
</div>
</template>

<script>
    export default {
        name: 'Instructors',
        mounted() {
            this.instructors = getInstructors();
        },
        data () {
            return {
                instructors: []
            }
        }
    }
    function getInstructors() {
        return JSON.parse(instructors);
    }
    var instructors = '[{"first": "Jill", "middle": "R.", "last": "Smith"}, {"first": "Michael", "middle": "B.", "last": "James"}, {"first": "Tom", "middle": "D.", "last": "Brown"}, {"first": "Bob", "middle": "K.", "last": "Roberts"}, {"first": "Sarah", "middle": "M.", "last": "Jane"}]';
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
