import Vue from 'vue'
import Vuex from 'vuex'
import common from './common'
import dashboard from './dashboard'

Vue.use(Vuex)

export default new Vuex.Store({
  modules: {
    common,
    dashboard
  }
})
