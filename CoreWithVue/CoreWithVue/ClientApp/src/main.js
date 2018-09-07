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
  /* template: '<App/>' */
  template: `
    <div id="app">
      <h1>Route Matching</h1>
      <ul>
        <li><router-link to="/home/demo/hellovue">/home/demo/hellovue</router-link></li>
        <li><router-link to="/home/default/helloworld">/home/default/helloworld</router-link></li>
      </ul>
      <p>Route context</p>
      <pre>{{ JSON.stringify($route, null, 2) }}</pre>
    </div>
  `
})
