// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>' 
  //template: `
  //  <div id="app">
  //    <h1>Route Matching</h1>
  //    <ul>
  //      <li><router-link to="/world">HelloWorld</router-link></li>
  //      <li><router-link to="/vue">HelloVue</router-link></li>
  //    </ul>

  //    <router-view/>
  //    <p>Route context</p>
  //    <pre>{{ JSON.stringify($route, null, 2) }}</pre>
  //  </div>
  //`
})
