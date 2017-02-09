$( window ).resize(function() {
	var wR  = $(window).width();
	var hR = $(window).height();
	
	$(".uruns .urun a").height($(".uruns .urun").width()-40);
	
});
$(function(){
	var w  = $(window).width();
	var h = $(window).height();

	
	$(".uruns .urun a").height($(".uruns .urun").width()-40);
	
	function time() {
        if (w > 1024) {
            var conW = w - $(".container").width();
            var NavALi = $(".nav li.active a");
            $(".borderof").attr("style", "left:" + ((NavALi.offset().left + NavALi.width()) - (((NavALi.width()) / 2) - 15)) + "px;");
            $(".nav li a").hover(function (ev) {
                var offset = ($(this).offset().left);
                var liW = $(this).width();
                $(".borderof").attr("style", "left:" + ((offset + liW) - (((liW) / 2) - 15)) + "px;");
            }, function (ev) {
                $(".borderof").attr("style", "left:" + ((NavALi.offset().left + NavALi.width()) - (((NavALi.width()) / 2) - 15)) + "px;");
            });
        }
    }
	time();
	setInterval(function () {
        time();
    }, 1000);
	

	$(".toggle").click(function() {
	   $(".nav").slideToggle(400);
	});
	if(w < 1368){
		$(".da-slider").height(h-100);
	}

	$(".insankaynaklari div[denet='zorunlu'] label").append("<b style='color:red;'>*</b>");



});

