/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["../Views/**/*.cshtml"],
    theme: {
        extend: {},
    },
    plugins: [require("daisyui")],

    daisyui: {
        themes: [
            {
                lighttheme: {
                    primary: "#F6E96B",
                    secondary: "#BEDC74",
                    accent: "#A2CA71", // payattention
                    "secondary-content": "#387F39", // textsecondary
                    "primary-content": "#000000", // textprimary
                    "base-100": "#FFEBD4", // hover
                    "base-200": "#F7B5CA", // selection
                    "base-300": "#F0A8D0", // focus
                },
            },
            {
                darktheme: {
                    primary: "#211951",
                    secondary: "#836FFF",
                    accent: "#15F5BA", // payattention
                    "secondary-content": "#FFAF00", // textsecondary
                    "primary-content": "#F0F3FF", // textprimary
                    "base-100": "#F5004F", // hover
                    "base-200": "#F9E400", // selection
                    "base-300": "#7C00FE", // focus
                },
            },
        ],
    },
};
