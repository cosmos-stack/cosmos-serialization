var url = require('url'),
    fs = require('fs');

module.exports = ( buildPath )=> {
  return {
      server: {
        baseDir: buildPath,
        index: 'project.html',
        // 中间件！
        middleware: function(req, res, next) {
            var urlObj = url.parse(req.url, true);
            next();
        }
      },
      port: 9000,
      // online:false,
      // open: false,
      open: "external",

      // open: "tunnel",
      // tunnel:"smallbear",
      notify: false,
      logPrefix: 'browserSync:',
      logLevel: 'info',
      ghostMode: false
   }
}
