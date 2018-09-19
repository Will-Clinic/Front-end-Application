'use strict';

$(document).ready(() => {
	var $cell = $('.card');

	//open and close card when clicked on card
	$cell.find('.js-expander').click(function () {

		var $thisCell = $(this).closest('.card');

		if ($thisCell.hasClass('is-collapsed')) {
			$cell.not($thisCell).removeClass('is-expanded').addClass('is-collapsed').addClass('is-inactive');
            $thisCell.removeClass('is-collapsed').addClass('is-expanded');

            $(this).closest('.fa-chevron-down').hide();
            $(this).closest('.fa-chevron-up').show();

            //$thisCell.$('.fa-chevron-down').hide();
            //$thisCell.$('.fa-chevron-up').show();
			if ($cell.not($thisCell).hasClass('is-inactive')) {
				//do nothing
			} else {
				$cell.not($thisCell).addClass('is-inactive');
			}

		} else {
			$thisCell.removeClass('is-expanded').addClass('is-collapsed');
            $cell.not($thisCell).removeClass('is-inactive');
            $('.fa-chevron-down').show();
            $('.fa-chevron-up').hide();
		}
	});
});