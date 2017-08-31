var through2 = require('through2'),
    gutil = require('gulp-util'),
    PluginError = gutil.PluginError,
    path = require('path'),
    fs = require('fs')


// 常量
const PLUGIN_NAME = 'gulp-distinct'


function rmFile( path ){
  fs.unlink( path )
}


var renderFiles = {}
/**
 * 去掉重复的文件
 * test.html, test.jsp        如果设置jsp为优先，则会删除同名的html
 * @method gulpDistinct
 * @param  {string}           extStr 优先的后缀名
 * @return {through2 steam}
 */
function gulpDistinct( extStr ) {
  if (!extStr || typeof extStr !== 'string' ) {
    throw new PluginError(PLUGIN_NAME, '没有优先级后缀参数或不为字符串!');
  }

  if( extStr.indexOf('.')<0 ) extStr = '.' + extStr


  return through2.obj( function( file, enc, cb ) {
    var _path = file.path,
      _ext = path.extname( _path ),
      _namePath = file.path.slice(0, -_ext.length)

      //还未加载此路径+文件名的文件
      if( !renderFiles[_namePath] ) {
        renderFiles[_namePath] = _path
        this.push( file )

      //已加载，但优先级更高
      }else if(_ext === extStr) {
        rmFile( renderFiles[_namePath] )
        this.push( file )

      //已加载，优先级低
      }else {
        rmFile( _path )
      }

    cb()
  } )
}

module.exports = gulpDistinct
