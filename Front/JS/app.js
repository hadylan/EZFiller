import { createApp, ref } from 'https://unpkg.com/vue@3/dist/vue.esm-browser.js'

createApp({
    setup() {
        const message = 'Hello Vue!';
        return {
            message
        }
    }
}).mount('#app')