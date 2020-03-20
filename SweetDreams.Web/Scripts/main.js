var width=$(window).width();
var height=$(window).height();

$(document).ready(function(){
	var videoWidth=$(".video").attr("width");
	var videoHeight=$(".video").attr("height");
	$(".video").css({"top":height/2-videoHeight/2,"left":width/2-videoWidth/2});
	$(window).resize(function(){
		width=$(window).width();
		height=$(window).height();
		$(".video").css({"top":height/2-videoHeight/2,"left":width/2-videoWidth/2});
	});
});			
$(".anim").hover(
	function(event){
		$(this).find(".nazad").css({"transform":"rotateY(0deg)","z-index":"1"});
		$(this).find(".vpered").css({"transform":"rotateY(180deg)","z-index":"0"});
	}, function(event){
		$(this).find(".nazad").css({"transform":"rotateY(-180deg)","z-index":"0"});
		$(this).find(".vpered").css({"transform":"rotateY(0deg)","z-index":"1"});
	}
	);
$(".knopka").click(function () {
	var src=$(this).attr("src");
	$(".video").attr("src",src);
	$(".video").css("visibility", "visible");
	$(".background").css("visibility", "visible");
});
$(".background").click(function(){
	$(".video").attr("src","");
	$(".video").css("visibility", "hidden");
	$(".background").css("visibility", "hidden");
});
