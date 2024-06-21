/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./**/*.{razor,html,cshtml}",
        "./node_modules/flowbite/**/*.js"
    ],
    theme: {
        fontFamily: {
            dancingScript: ["DancingScript", "sans-serif"]
        },
    },
    plugins: [
        require('flowbite/plugin')
    ],
}
