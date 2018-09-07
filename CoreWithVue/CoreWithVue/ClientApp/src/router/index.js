import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import HelloVue from '@/components/HelloVue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/world',
      name: 'HelloWorld',
      component: HelloWorld
    },
    {
      path: '/vue',
      name: 'HelloVue',
      component: HelloVue
    }
  ]
})
