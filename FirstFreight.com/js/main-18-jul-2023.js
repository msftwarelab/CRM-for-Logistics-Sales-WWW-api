// mobile menu show/hide on trigger
$(document).ready(function () {
	$("#request_demo").click(function (e) {
		e.preventDefault();
		$(".demo_select_button_wrapper_content").toggleClass("active");
	});

	$(document).click(function (e) {
		let target = $(e.target);
		if (target.parents(".rqst_demo_li").length <= 0) {
			$(".demo_select_button_wrapper_content").removeClass("active");
		}
	});

	$('a.toggle-menu').click(function (event) {
		event.stopPropagation();
		if (!$(this).hasClass('active')) {
			$('.mobile-menu').stop(true, true).fadeIn(300);
			$(this).find('i').removeClass('fa-bars');
			$(this).find('i').addClass('cross').html('&#735;');
			$(this).addClass('active');
			$('html,body').addClass('overflow');
		} else {
			$('.mobile-menu').stop(true, true).fadeOut(300);
			$(this).find('i').removeClass('cross').html('');
			$(this).find('i').addClass('fa-bars');
			$(this).removeClass('active');
			$('html,body').removeClass('overflow');
		}
	});

	$('.mobile-menu a').click(function () {
		$('.mobile-menu').stop(true, true).fadeOut(300);
		$('a.toggle-menu').find('i').removeClass('cross').html('');
		$('a.toggle-menu').find('i').addClass('fa-bars');
		$('a.toggle-menu').removeClass('active');
		$('html,body').removeClass('overflow');
	});
});

// nav menu
$(document).ready(function () {
	$('ul.menu a, ul.nav a').click(function (event) {
		$('ul.menu a, ul.nav a').removeClass('selected');
		$(this).addClass('selected');
		var getID = $(this).attr('href');
		var dataRef = $(this).attr('data-ref');
		var itemName = $(this).text();
		$('a[data-ref="' + dataRef + '"]').addClass('selected');
		var sectionID = getID.substring(1, getID.length);

		// Intercom trackEvent
		var metadata = { item: itemName };
		Intercom('trackEvent', 'menuitem-click', metadata);

		if ($(sectionID).length > 0) {
			if (sectionID !== "" && sectionID.indexOf('#') > -1) {
				event.preventDefault();
				$('html, body').animate({
					scrollTop: $(sectionID).offset().top - 50
				}, 1000);
			}
		}
	});
});

// Intercom - CTA's trackEvent
$(document).ready(function () {
	$('button.btn').click(function () {
		var itemName = $(this).text();
		var metadata = { item: itemName };
		Intercom('trackEvent', 'button-click', metadata);
	});
});

// plugin for animations on scroll
if ($('.home-page').length > 0) {
	new WOW({ offset: 100 }).init();
}

// pricing toggle
$(document).ready(function () {
	$('.price-btns a').click(function (event) {
		event.stopPropagation();
		$('.price-btns a').removeClass('active');
		$(this).addClass('active');
		var planCost = $(this).attr('data-cost');
		var planUrl = $(this).attr('data-url');
		var planCycle = $(this).attr('data-cycle');
		$('#pricing .plan-cost').text(planCost);
		$('#pricing .plan-cycle').text(planCycle);
		$('#pricing a.trialBtn').attr('onclick', planUrl);
	});
});

// cookie consent
function createCookie(name, value, days) {
	var date, expires;
	if (days) {
		date = new Date();
		date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
		expires = "; expires=" + date.toGMTString();
	}
	else {
		expires = "";
	}
	document.cookie = name + "=" + value + expires + "; path=/";
}

function getCookie(name) {
	var dc = document.cookie;
	var prefix = name + "=";
	var begin = dc.indexOf("; " + prefix);
	if (begin == -1) {
		begin = dc.indexOf(prefix);
		if (begin != 0) return null;
	}
	else {
		begin += 2;
		var end = document.cookie.indexOf(";", begin);
		if (end == -1) {
			end = dc.length;
		}
	}
	return decodeURI(dc.substring(begin + prefix.length, end));
}

$(document).ready(function () {
	if (getCookie('cookieSeen') == null) {
		$('#cookiePopup').show();
	} else if (getCookie('cookieSeen')) {
		$('#cookiePopup').remove();
	}

	$('#closeCookiePopup').click(function (event) {
		createCookie('cookieSeen', 'true', 365);
		$('#cookiePopup').hide();
	});
});

$navigation = $('.navbar-wrapper');
$(window).scroll(function () {
	var scrollTop = $(window).scrollTop();
	if (scrollTop > 10) {
		$navigation.addClass('sticky');
	} else {
		$navigation.removeClass('sticky');
	}
});

// Banner Text FontSize Calculation
function bannerTextSize() {
	if ($(window).width() <= 575 && $(window).width() < $(window).height()) {
		var defaultFontRatio = 0.16; // font 56/width 375
		var getHeaderHeight = $('.navbar-wrapper').outerHeight(true);
		var getWindowWidth = $(window).width();
		var getWindowHeight = $(window).height();
		var calcFontSize = getWindowWidth * defaultFontRatio;
		$('.banner-caption h1').css('fontSize', calcFontSize);

		setTimeout(function () {
			var viewPortHeight = getWindowHeight - getHeaderHeight;
			var getBannerHeight = $('.banner-caption').outerHeight();
			var remainingSpace = viewPortHeight - getBannerHeight;
			var halfSpace = remainingSpace / 3;

			if (halfSpace > 0) {
				$('.banner-caption').css('marginTop', halfSpace);
			}
		}, 100);
	}
}

$(function () {
	bannerTextSize();

	$(window).on('resize', function () {
		if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
			if ($(window).width() > $(window).height()) {
				$('.banner-caption , .banner-caption h1').removeAttr("style");
			}
			else {
				bannerTextSize();
			}
		}
	});
});

$(document).on('click', 'a', function (e) {
	if (this.hash !== "") {
		// e.preventDefault();

		var hash = this.hash;

		$('html, body').animate({
			scrollTop: $(hash).offset().top - 80
		}, 1200, function () {

			// window.location.hash = hash;
		});
	}
});


jQuery('.section-comparison-two-sides .provider-logo').matchHeight();
jQuery('.section-comparison-two-sides--container .comparison-col .comparison-col--header').matchHeight();