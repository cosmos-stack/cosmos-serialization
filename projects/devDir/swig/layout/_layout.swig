<!DOCTYPE html>
<html{% if htmlClass %} class="{{ htmlClass }}"{% endif %}>
<head>
	<meta charset="UTF-8">
	<title>{% block title %}{{ title }}{% endblock %}</title>
	<meta name="keywords" content="">
	<meta name="description" content="">
  <meta http-equiv="X-UA-Compatible" content="IE=Edge">
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, minimum-scale=1, user-scalable=no">
  {% block meta %}{% endblock %}
  <link rel="shortcut icon" href="/favicon.ico" type="image/x-icon" >
  <link rel="stylesheet" href="{{ css.common }}">
	{%- block style %}{% endblock -%}

	{% block preScript %}{% endblock %}
</head>
<body {% if bodyClass %}class="{{ bodyClass }}"{% endif %}>
	{% block g-head %}
	<div class="g-head">
	    {% include '../component/_nav.swig' %}
      <div class="dotnet-theme">
        <div class="inner">
           <div class="brand">
             <img src="{{ image + 'brand.png'}}" alt="">
           </div>
           <div class="slogan">
            <span class="text"><img src="{{ image + 'logo-lg.png' }}" alt="">项目</span>
            <p>Making .NET greater... <strong>together</strong></p>
           </div>
           <section class="faq">
             <ul>
               <li><a href="">成员项目说明</a></li>
               <li><a href="">如何加入我们</a></li>
             </ul>
           </section>
        </div>
      </div>
	</div>
	{% endblock %}

  <div class="g-main">
    {% block main %}{% endblock %}
  </div>

	{% block g-footer %}
	<div class="g-footer">
		<div class="our-message">
      <div class="inner">
         <span class="media">dotNETcore</span>
         <div class="content">
           <h1>春种一粒粟，秋收万颗子。</h1>
           <p>凝聚吾辈之力，汇聚诸君之绩，披荆斩棘，同舟共济，吾等即奇迹。</p>
         </div>
       </div>
    </div>
	</div>
	{% endblock %}
	<script src="/js/common.js" ></script>
	{% block scripts %}{% endblock %}
</body>
</html>
