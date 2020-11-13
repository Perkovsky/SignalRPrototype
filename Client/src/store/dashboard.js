import axios from 'axios'

export default {
  state: {
    dashboard: { c1: 'N/A', c2: 'N/A', c3: 'N/A', uuid: 'N/A' }
  },
  mutations: {
    setDashboard (state, payload) {
      state.dashboard = payload
    }
  },
  actions: {
    async fetchDashboard ({commit}) {
      commit('clearError')
      try {
        console.log('test-1')
        let url = 'http://localhost:5000/dashboard'
        let response = await axios.get(url)
        console.log('test-2')
        console.log(response)
        commit('setDashboard', response.data)
      } catch (error) {
        commit('setError', error.message)
      }
    }
  },
  getters: {
    dashboard: state => state.dashboard
  }
}
