<div class="nav-row">
  <div class="inner">
  <span class="nav-switch" id="openNavMenu">
    <b class="ui-icons-cate"></b>
  </span>
  <div class="logo">
    <a href="/"><img src="{{image + 'logo.png'}}" alt=""></a>
    <span class="chat-group"><a href="https://shang.qq.com/wpa/qunwpa?idkey=2fbe72c6d806df94d9e6644bbfb7a392669b5e858eccdc8335d0859827182e2f" target="_blank">QQ群: 436035237</a></span>
  </div>
  <div class="nav-menu" id="navMenu">
    <div class="logo">
      <img src="{{image + 'logo.png'}}" alt="">
    </div>
    <ul class="list-block">
      <li>
        <a href="" class="item-link{% if navCur == 'home' %} active{% endif %}">
          <span class="item-media">
            <i class="iconfont-home"></i>
          </span>
          <div class="item-content">首页</div>
        </a>
      </li>
      <li>
        <a href="" class="item-link{% if navCur == 'folder' %} active{% endif %}">
          <span class="item-media">
            <i class="iconfont-folder"></i>
          </span>
          <div class="item-content">文档</div>
        </a>
      </li>
      <li>
        <a href="" class="item-link{% if navCur == 'project' %} active{% endif %}">
          <span class="item-media">
            <i class="iconfont-project"></i>
          </span>
          <div class="item-content">项目</div>
        </a>
      </li>
      <li>
        <a href="" class="item-link{% if navCur == 'member' %} active{% endif %}">
          <span class="item-media">
            <i class="iconfont-member"></i>
          </span>
          <div class="item-content">成员</div>
        </a>
      </li>
      <li>
        <a href="" class="item-link{% if navCur == 'contribution' %} active{% endif %}">
          <span class="item-media">
            <i class="iconfont-contribution"></i>
          </span>
          <div class="item-content">贡献</div>
        </a>
      </li>
      <li>
        <a href="" class="item-link{% if navCur == 'activity' %} active{% endif %}">
          <span class="item-media">
            <i class="iconfont-activity"></i>
          </span>
          <div class="item-content">活动</div>
        </a>
      </li>
    </ul>
  </div>
  <div class="github">
    <span>博客</span>
    <a target="_blank" href="https://github.com/dotnetcore" class="item-link{% if navCur == 'activity' %} active{% endif %}">
        <svg aria-hidden="true" class="github-icon" version="1.1" viewBox="0 0 16 16">
          <path fill-rule="evenodd" d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.013 8.013 0 0 0 16 8c0-4.42-3.58-8-8-8z"></path>
        </svg>
    </a>
  </div>
  </div>
</div>


