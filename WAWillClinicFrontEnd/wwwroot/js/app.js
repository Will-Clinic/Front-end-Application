'use strict';

$(document).ready(() => {
	$('.fa-bars').on('click', () => {
		$('header').slideDown();
	});

	$('.fa-times').on('click', () => {
		$('header').slideUp();
	});
})