var fs = require('fs'),
    path = require('path')

module.exports = ( devPath, buildPath )=> {
  /**
   * 级联删除文件及文件夹
   * @method deleteFolderRecursive
   * @param  {[type]}              path [description]
   */
  function deleteFolderRecursive( path ) {
    var files = []

    console.warn( '------del Dir: ', path )
    if( fs.existsSync(path) ) {
        files = fs.readdirSync(path)
        files.forEach(function(file, ix) {
            var curPath = path + '/' + file
            if(fs.statSync(curPath).isDirectory()) { // recurse
                deleteFolderRecursive(curPath)
            } else { // delete file
                console.warn( '------del File: ', curPath )
                fs.unlinkSync(curPath)
            }
        })
        fs.rmdirSync(path)
    }
  }

  /**
   * 获取路径
   * @method getPath
   * @param  {string} sPath 源路径
   * @param  {string} dist  默认输出路径
   * @param  {string} blob  默认blob路径
   * @return {string}       最终生成的路径
   */
  function getPath( sPath, dist, blob ) {
    var _src, _build
    if( typeof sPath === 'string' ) {
      _src = sPath
      _build = path.join( dist,
                          path.dirname(
                            path.relative( getBlobDir( blob ), _src ) ) )
      console.log( 'src: ', _src )
      console.log( 'build: ', _build )
    }else {
      _src = blob
      _build = dist
    }

    return {
      src: _src,
      build: _build,
    }
  }

  /**
   * 获取路径中除去blog语法外的路径
   * @method getBlobDir
   * @param  {[type]}   str [description]
   * @return {[type]}       [description]
   */
  function getBlobDir( str ) {
    var _match = str.match( /[^*()_!]+/ )

    if( _match[0] ) return _match[0]
    else return str
  }

  return {
    deleteFolderRecursive,
    getPath,
  }
}
