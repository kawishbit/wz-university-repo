import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'
import mkcert from 'vite-plugin-mkcert'


// https://vitejs.dev/config/
export default defineConfig({
  plugins: [vue(), mkcert()],
    server: {
        port: 3399,
        https: true,
        strictPort : true,
        proxy: {
            '/api' : {
                target: 'https://localhost:7034',
                changeOrigin: true,
                secure: false,
                rewrite: (path) => path.replace(/^\/api/, '/api')
            }
        }
    }
})
