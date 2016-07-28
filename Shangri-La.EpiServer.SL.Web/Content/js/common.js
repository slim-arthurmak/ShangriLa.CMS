var Shangrila=window.Shangrila||{};Shangrila.screenWidth=$(window).width(),Shangrila.screenHeight=$(window).height(),Shangrila.extraSmall=768,Shangrila.small=992,Shangrila.medium=1200,Shangrila.modules=[],function(a){a.fn.tagRemover=function(){return this.each(function(){var b=a(this),c=b.text();b.replaceWith(c)})}}(jQuery),$.fn.serializeObject=function(){var a={},b=this.serializeArray();return $.each(b,function(){void 0!==a[this.name]?(a[this.name].push||(a[this.name]=[a[this.name]]),a[this.name].push(this.value||"")):a[this.name]=this.value||""}),a},function(a){a.fn.inlineSVG=function(){return this.each(function(){var a=jQuery(this),b=a.attr("id"),c=a.attr("class"),d=a.attr("src");jQuery.get(d,function(d){var e=jQuery(d).find("svg");"undefined"!=typeof b&&(e=e.attr("id",b)),"undefined"!=typeof c&&(e=e.attr("class",c+" replaced-svg")),e=e.removeAttr("xmlns:a"),a.replaceWith(e)},"xml")})}}(jQuery),$.fn.heightAdjust=function(a){var b=0;a===!1?($(this).each(function(){b<$(this).innerHeight()&&(b=$(this).innerHeight())}),$(this).css("height",b)):($(this).each(function(){$(this).removeAttr("style")}),$(this).each(function(){b<$(this).innerHeight()&&(b=$(this).innerHeight())}),$(this).css("height",b))},$(".svg").inlineSVG(),Shangrila.debouncer=function(a,b){var c;return b=b||500,function(){var d=this,e=arguments;clearTimeout(c),c=setTimeout(function(){a.apply(d,Array.prototype.slice.call(e))},b)}},window.orientationchange?window.attachEvent?window.attachEvent("orientationchange",Shangrila.viewportChange,!1):window.addEventListener("orientationchange",Shangrila.viewportChange,!1):$(window).on("resize",Shangrila.debouncer(function(a){Shangrila.screenWidth!=$(window).width()&&Shangrila.viewportChange(),Shangrila.screenWidth=$(window).width(),Shangrila.screenHeight=$(window).height()})),Shangrila.viewportChange=function(){Shangrila.screenWidth=$(window).width(),Shangrila.screenHeight=$(window).height(),Shangrila.triggerObserver("viewportChange")},Shangrila.triggerObserver=function(a){var b=Shangrila.modules.length;if(b>0)for(var c=0;b>c;c++){var d=Shangrila.modules[c];Shangrila[d][a]&&Shangrila[d][a]()}},Shangrila.scrollToElement=function(a,b,c){var d=a.offset().top-$("header").outerHeight()+(b?b:0);$("html, body").animate({scrollTop:d}),c&&c()},Shangrila.scrollToTop=function(){Shangrila.bodyScrollPosition=$(window).scrollTop(),$("html, body").scrollTop(0)},Shangrila.scrollToPosition=function(a){a=a?a:Shangrila.bodyScrollPosition,$("html, body").animate({scrollTop:a})},Shangrila.scrollToPositionWithoutAnimation=function(a){a=a?a:Shangrila.bodyScrollPosition,$(window).scrollTop(a)},Shangrila.positionInput=function(){if(Modernizr.touch){var a=$("input, textarea").not("header input, :input[type=button], :input[type=submit], :input[type=reset]");$(a).each(function(a){var b=$(this);b.on("focus, click",function(a){Shangrila.scrollToElement(b)})})}},Shangrila.accordionHandler=function(a,b,c,d,e){"none"==c.css("display")?(d.slideUp(),b.removeClass("active"),c.slideDown(400,function(b){a.addClass("active"),e()})):(c.slideUp(),a.removeClass("active"))},Shangrila.overlayShow=function(){var a=$(".common-overlay"),b=$(document).height();a.fadeIn(),a.css({height:b})},Shangrila.overlayHide=function(){var a=$(".common-overlay");"block"!=$(".destination-overlay").css("display")&&a.hide()},Shangrila.popUpHide=function(){$(".common-popup-block .close-btn").parents(".common-popup-block").hide()},Shangrila.closeButtonHandler=function(a){var b=Shangrila,c=$(".common-popup-block .close-btn");c.on("click",function(c){c.preventDefault();var d=$(this);d.next().remove(),$(".common-overlay").removeClass("stackup"),b.overlayHide(),b.scrollToPositionWithoutAnimation(),Shangrila.popUpHide(),a&&a()})},Shangrila.viewMoreButtonHandler=function(a){var b=$(".view-more-items"),c=b.text(),d=b.find("a").attr("data-view-less-text");b.on("click",function(a){a.preventDefault();var b=$(this);b.toggleClass("opened"),b.closest(".carousel-container").find(".extra-item").toggleClass("hidden-extra"),b.hasClass("opened")===!0?b.find("a").text(d):b.find("a").text(c)})},Shangrila.placeholderHandler=function(){!function(a){a.support.placeholder="placeholder"in document.createElement("input")}(jQuery),$(function(){$.support.placeholder||($("[placeholder]").focus(function(){$(this).val()==$(this).attr("placeholder")&&$(this).val("")}).blur(function(){""===$(this).val()&&$(this).val($(this).attr("placeholder"))}).blur(),$("[placeholder]").parents("form").submit(function(){$(this).find("[placeholder]").each(function(){$(this).val()==$(this).attr("placeholder")&&$(this).val("")})}))})},Shangrila.showHideSocialIcons=function(){$(".social-icons-wrapper").each(function(){var a=$(this),b=a.find(".social-more"),c=a.find(".social-less"),d=a.find(".social-icons ul li").not(b).not(c),e=a.attr("data-visible");Shangrila.showSocialIcons(d,e,b,c)})},Shangrila.showSocialIcons=function(a,b,c,d){function e(){a.each(function(c,d){c>b-1&&$(a[c]).addClass("social-hide")}),c.removeClass("social-hide"),d.addClass("social-hide")}a.length;e(),a.each(function(c,d){c>b-1&&$(a[c]).addClass("social-hide")}),c.on("click",function(){a.removeClass("social-hide"),$(this).addClass("social-hide"),d.removeClass("social-hide")}),d.on("click",function(){e()})},Shangrila.showDestinationOverlay=function(){$('a[data-action="change-destination"]').on("click",function(a){a.preventDefault(),Shangrila.overlayShow(),$(".destination-overlay").slideDown(),Shangrila.lockBodyScroll()})},Shangrila.hideDestinationOverlay=function(){$(".destination-overlay .close a").on("click",function(a){a.preventDefault(),$(".destination-overlay").slideUp(400,function(){Shangrila.overlayHide()}),Shangrila.unlockBodyScroll()})},Shangrila.setDestination=function(){$(".destination-overlay ul.list-unstyled li > a").on("click",function(a){a.preventDefault(),$('*[data-type="change-destination"]').text($(this).text()),$(".destination-overlay").slideUp(400,function(){Shangrila.overlayHide()}),Shangrila.unlockBodyScroll()})},Shangrila.lockBodyScroll=function(){Shangrila.bodyScrollPosition=$("html, body").scrollTop(),Shangrila.screenWidth<Shangrila.extraSmall&&$("html, body").scrollTop(0),$("html, body").css("overflow","hidden")},Shangrila.unlockBodyScroll=function(){Shangrila.scrollToPosition(),$("html, body").css("overflow","auto")},Shangrila.unlockBodyScrollDirectly=function(){Shangrila.scrollToPositionWithoutAnimation(),$("html, body").css("overflow","auto")},Shangrila.setEscapeElement=function(a){Shangrila.escapeElement=a},Shangrila.setEscapeCallback=function(a){Shangrila.escapeCallback=a},Shangrila.hideElement=function(){var a=Shangrila.escapeElement,b=Shangrila.escapeCallback;$(a).is(":visible")&&$(a).slideUp(400,function(){b&&b()})},$(document).click(function(a){var b=$(a.target);b.hasClass("ui-datepicker-prev")||b.hasClass("ui-datepicker-next")||b.hasClass("delete-room")||$.contains($("#ui-datepicker-div")[0],$(b)[0])||b.closest(Shangrila.escapeElement).length||b.is(Shangrila.escapeElement)||(Shangrila.hideElement(),Shangrila.setEscapeElement(null),Shangrila.setEscapeCallback(null))}),$(document).on("keyup",function(a){var b=a.keyCode||a.which;27==b&&($(a.target).hasClass("hasDatepicker")?$(a.target).blur():Shangrila.hideElement())}),$.fn.extend({animateCss:function(a){var b="webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend";$(this).addClass("animated "+a).one(b,function(){$(this).removeClass("animated "+a)})}}),$(document).ready(function(a){Shangrila.triggerObserver("init"),Shangrila.showDestinationOverlay(),Shangrila.hideDestinationOverlay(),Shangrila.setDestination(),Shangrila.showHideSocialIcons(),Shangrila.closeButtonHandler(),Shangrila.viewMoreButtonHandler()}),$(window).load(function(){Shangrila.triggerObserver("adjustHeight"),Shangrila.triggerObserver("adjustHeightMobile")});