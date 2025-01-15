/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./Views/**/*.cshtml", "./Views/*.cshtml", "./Areas/Admin/Views/**/*.cshtml", "./Areas/Admin/Views/*.cshtml"],
  theme: {
    extend: {},
  },
  plugins: [
      require('daisyui'),
  ],
  daisyui: {
    themes: ["corporate"],
  },
}
