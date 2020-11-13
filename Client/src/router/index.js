import Vue from 'vue'
import Router from 'vue-router'
import Dashboard from '@/components/Dashboard'
import PageNotFound from '@/components/PageNotFound'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Dashboard',
      component: Dashboard
    },
    {
      path: '*',
      component: PageNotFound
    }
  ],
  mode: 'history'
})
