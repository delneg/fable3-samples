var path = require("path");

var babelOptions = {
  presets: [
    ["@babel/preset-env", {
      "targets": {
        "node": true,
      },
    }]
  ],
};

console.log("Bundling function...");

module.exports = {
  mode: "production",
  target: "node",
  node: {
    __dirname: false,
    __filename: false,
  },
  entry: './build/main.js',
  output: {
    path: path.join(__dirname, "./build"),
    filename: 'App.compiled.js',
    library:"app",
    libraryTarget: 'commonjs'
  },
  plugins: [ ],
  module: {
    rules: [{
        test: /\.js$/,
        exclude: /node_modules/,
        use: {
          loader: 'babel-loader',
          options: babelOptions
        },
      }
    ]
  },
};