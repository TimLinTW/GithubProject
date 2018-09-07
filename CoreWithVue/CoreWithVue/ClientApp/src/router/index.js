import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import HelloVue from '@/components/HelloVue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/home/:default/:helloworld',
      name: 'HelloWorld',
      component: HelloWorld
    },
    {
      path: '/home/:demo/:hellovue',
      name: 'HelloVue',
      component: HelloVue
    }
  ]
})
