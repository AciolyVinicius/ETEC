

  /* INICIO RATING DE NOTAS */
  var $star_rating = $('.star-rating .fa');

  var SetRatingStar = function() {
    return $star_rating.each(function() {
      if (parseInt($star_rating.siblings('input.rating-value').val()) >= parseInt($(this).data('rating'))) {
        return $(this).removeClass('fa-star-o').addClass('fa-star');
      } else {
        return $(this).removeClass('fa-star').addClass('fa-star-o');
      }
    });
  };

  $star_rating.on('click', function() {
    $star_rating.siblings('input.rating-value').val($(this).data('rating'));
    return SetRatingStar();
  });

  SetRatingStar();
  $(document).ready(function() {

  });
  /* FIM RATING DE NOTAS */

  /* INICIO RATING DE PESO DA AVALIACAO */
  var $anchor_rating = $('.anchor-rating .fa');

  var SetRatingAnchor = function() {
    return $anchor_rating.each(function() {
      if (parseInt($anchor_rating.siblings('input.rating-value').val()) >= parseInt($(this).data('rating'))) {
        return $(this).removeClass('fa-plus-square').addClass('fa-anchor');
      } else {
        return $(this).removeClass('fa-anchor').addClass('fa-plus-square');
      }
    });
  };

  $anchor_rating.on('click', function() {
    $anchor_rating.siblings('input.rating-value').val($(this).data('rating'));
    return SetRatingAnchor();
  });

  SetRatingAnchor();
  $(document).ready(function() {

  });
  /* FIM RATING DE PESO DA AVALIACAO */