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
    setDashboard ({commit}, payload) {
      commit('setDashboard', payload)
    },
    async fetchDashboard ({commit}) {
      commit('clearError')
      try {
        let url = 'http://localhost:5000/dashboard'
        let response = await axios.get(url)
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
