'use strict';

$(document).ready(() => {
	$('.fa-bars').on('click', () => {
        $('#blue-head').slideDown();
        $('main').hide();
	});

	$('.fa-times').on('click', () => {
        $('#blue-head').slideUp();
        $('main').show();
	});
})