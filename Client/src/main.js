import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import vuetify from './plugins/vuetify'
import VueSignalR from '@latelier/vue-signalr'

Vue.use(VueSignalR, 'http://localhost:5000/hubs/dashboard');

Vue.config.productionTip = false

new Vue({
  router,
  store,
  vuetify,
  render: h => h(App),

  created() {
    this.$socket.start({
      log: true // Active only in development for debugging.
    });
  }
}).$mount('#app')
