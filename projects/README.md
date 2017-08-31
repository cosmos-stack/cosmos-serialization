1、首先运行 npm install 安装所有依赖包。

2、执行 node run build 生成构建后的目录。

3、以 2 的目录为根目录，执行 node run server 启动本地开发服务器。

4、如果要新建一个首页，直接在devDir\swig\html 复制一个 project.swig 然后修改文件名再编辑内容。
   gulp-swig 会自动生成html文件到 2 中。