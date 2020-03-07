<template>
  <div id="app">
     <NavBar/>
     <router-view/>
  </div>
</template>

<script>
import NavBar from './components/NavBar.vue'

export default {
  name: 'App',
  components: {
    NavBar
  }
}
</script>

<style>
.heading {
    font-family: Arial, Helvetica, sans-serif;
    color: green;
}

#home-heading {
    font-family: Arial, Helvetica, sans-serif;
    color: blue;
}

p {
    font-family: Arial, Helvetica, sans-serif;
    color: red;
}

ol {
    font-family: Arial, Helvetica, sans-serif;
    color: purple;
}
</style>
