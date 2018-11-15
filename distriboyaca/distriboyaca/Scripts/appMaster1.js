$(document).ready(function () {
    $(".button-collapse").sideNav();
    $('.slider').slider({ height: 550 });
    $('.modal').modal();
});

function initMap() {
    var myLatLng = { lat: 4.7111207, lng: -74.1995376 };
    var map = new google.maps.Map(document.getElementById("mapa"), {
        center: myLatLng,
        zoom: 15
    });
    var marker = new google.maps.Marker({
        map: map,
        position: myLatLng,
        title: "DISTRIBOYACA"
    });
}
