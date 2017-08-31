var fs = require('fs'),
    gulp = require('gulp'),
    sass = require('gulp-sass'),
    autoprefixer = require('gulp-autoprefixer'),
    csscomb      = require('gulp-csscomb'),
    spritesmith  = require('gulp.spritesmith'),
    rename       = require("gulp-rename"),
    swig         = require('gulp-swig'),
    browserSync  = require('browser-sync').create('dotnet'),

    sassOptions     = {},
    prefixerOptions = {browsers: [
      'Chrome >= 20',
      'Firefox >= 24', 
      'Explorer >= 9',
      'Opera >= 12',
      'iOS >= 6',
      'Safari >= 8']
    },
    swigOptions     = require( './swigOptions' ),
    sprites         = require('./sprites'),
    utils           = require( './util' );

module.exports = ( devPath, buildPath, distPath )=> {
  // server option
  var serverOptions = require( './serverOptions' )(buildPath),
      {getPath, deleteFolderRecursive} = utils( devPath, buildPath );

  // -----编译任务
  /**
   * sass编译
   * @method sass
   * @param  {string} src 编译对象
   * @return {gulp.stream}       gulp数据流
   */
  function gulpSass( src ) {
    var pathOb = getPath( src, buildPath + '/css', devPath + '/scss/**/*.scss' );

    return gulp.src( pathOb.src )
      .pipe( sass( sassOptions ).on('error', sass.logError) )
      .pipe( autoprefixer(prefixerOptions) ) // 兼容
      .pipe( csscomb() )
      .pipe( gulp.dest( pathOb.build ) )
      .pipe( browserSync.reload({stream: true}) )
  }
  gulp.task( 'sass', ()=> {
    return gulpSass();
  })

  /**
   * 编译 swig
   * @method gulpSwig
   * @param  {string} src 编译对象
   * @return {gulp.stream}       gulp数据流
   */
  function gulpSwig( src ) {
    var pathOb = getPath( src, buildPath + '',devPath + '/swig/html/**/*.swig');

    console.log( 'swig: ', pathOb.build );
    return gulp.src( pathOb.src )
        .pipe(rename( (path)=> {
           console.log(path);
           return path;
        }))
      .pipe( swig( swigOptions ) )
      .pipe( gulp.dest( pathOb.build ) )
      .pipe( browserSync.reload({stream: true}) )
  }
  gulp.task( 'swig', ()=> {
    return gulpSwig()
  })

  /**
   * 编译 js
   * @method gulpJs
   * @param  {string} src        编译对象
   * @return {gulp.stream}       gulp数据流
   */
  function gulpJs( src ) {
    var pathOb = getPath( src, buildPath + '/js', devPath + '/js/**/*.js' );

    return gulp.src( pathOb.src )
      .pipe( gulp.dest( pathOb.build ) )
      .pipe( browserSync.reload({stream: true}) )
  }
  gulp.task( 'js', ()=> {
    deleteFolderRecursive( buildPath + '/js' );

    return gulpJs()
  })

  /**
   * 生成雪碧图
   * @method gulpSprite
   * @param  {[type]}   name [description]
   * @return {string} (scss路径)
   */
  function gulpSprite( name ) {

    var smithTar = gulp.src( devPath + '/images/sprites/'+name+'/*.png')
          .pipe( spritesmith(
            {
              cssOpts: {functions: false},
              imgName: name+'_sprite.png',
              cssName: '_' + name + '.scss',
              imagePath: '../images/',
              cssTemplate: './config/template.scss.handlebars',
            }
          ) )

    smithTar.img.pipe( gulp.dest( buildPath + '/images') )
    smithTar.css.pipe( gulp.dest( devPath + '/scss/sprites') )

    return 'sprites/' + name
  }
  gulp.task( 'sprites', ()=> {
    deleteFolderRecursive( devPath + '/scss/sprites' )

    var _paths = []
    sprites.forEach((el, ix)=> {
      _paths.push( '@import "' + gulpSprite( el ) + '";\n' )
    })

    fs.writeFile( devPath + '/scss/_sprites.scss', _paths.join(''), (error)=> {
      console.warn( 'file success!', error )
    })
  }),
  gulp.task( 'copy', ()=> {
       gulp.src(devPath + '/fonts/*')
      .pipe( gulp.dest(buildPath + '/fonts') )

    return gulp.src(devPath + '/images/**/*')
      .pipe( gulp.dest(buildPath + '/images') )
  })
  gulp.task( 'build', ['sass', 'swig', 'js', 'copy'])


  // -----查看文件变动任务
  gulp.task( 'watchSass', ()=> {
    return gulp.watch( devPath + '/scss/**/*.scss', (evt)=> {
      var _path = evt.path

      if( /(\/|\\)_(\w+)/.test( _path ) ) {
        return gulpSass()
      }else return gulpSass( _path )
    } )
  })
  gulp.task( 'watchSwig', ()=> {
    return gulp.watch( devPath + '/swig/**/*.swig', (evt)=> {
      var _path = evt.path

      if( /(\/|\\)_(\w+)/.test( _path ) ) {
        return gulpSwig()
      }else return gulpSwig( _path )
    })
  })
  gulp.task( 'watchJs', ()=> {
    return gulp.watch( devPath+'/js/**/*.js', (evt)=> {
      return gulpJs( evt.path )
    })
  })

  // ----server
  gulp.task( 'server', ['watchSass', 'watchSwig', 'watchJs'], ()=> {
    browserSync.init( serverOptions )
  } )
}
