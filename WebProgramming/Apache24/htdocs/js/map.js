/**
 * @license
 * Copyright 2019 Google LLC. All Rights Reserved.
 * SPDX-License-Identifier: Apache-2.0
 */
let map;

function getDistanceFromLatLonInKm(lat1,lng1,lat2,lng2) {
  function deg2rad(deg) {
      return deg * (Math.PI/180)
  }

  var R = 6371; // Radius of the earth in km
  var dLat = deg2rad(lat2-lat1);  // deg2rad below
  var dLon = deg2rad(lng2-lng1);
  var a = Math.sin(dLat/2) * Math.sin(dLat/2) + Math.cos(deg2rad(lat1)) * Math.cos(deg2rad(lat2)) * Math.sin(dLon/2) * Math.sin(dLon/2);
  var c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1-a));
  var d = R * c; // Distance in km
  return d;
}

function initMap() {
  const myLatLng1 = { lat: 36.7717, lng: 126.9496 };
  const myLatLng2 = { lat: 36.7893, lng: 127.1294 };
  const map = new google.maps.Map(document.getElementById("map"), {
    zoom: 4,
    center: myLatLng1,
  });

  new google.maps.Marker({
    position: myLatLng1,
    map,
    title: "아산 폴리텍",
  });

  new google.maps.Marker({
    position: myLatLng2,
    map,
    title: "우리집",
  });
  
  alert("Distance: "+getDistanceFromLatLonInKm(
    myLatLng1.lat, myLatLng1.lng, myLatLng2.lat, myLatLng2.lng)+"km");
}

window.initMap = initMap;
