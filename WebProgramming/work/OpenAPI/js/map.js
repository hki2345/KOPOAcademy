/**
 * @license
 * Copyright 2019 Google LLC. All Rights Reserved.
 * SPDX-License-Identifier: Apache-2.0
 */
let map;
var json =
{
  "rentBikeStatus": {
      "list_total_count": 500,
      "RESULT": {
          "CODE": "INFO-000",
          "MESSAGE": "정상 처리되었습니다."
      },
      "row": [
          {
              "rackTotCnt": "15",
              "stationName": "102. 망원역 1번출구 앞",
              "parkingBikeTotCnt": "10",
              "shared": "67",
              "stationLatitude": "37.55564880",
              "stationLongitude": "126.91062927",
              "stationId": "ST-4"
          },
          {
              "rackTotCnt": "14",
              "stationName": "103. 망원역 2번출구 앞",
              "parkingBikeTotCnt": "11",
              "shared": "79",
              "stationLatitude": "37.55495071",
              "stationLongitude": "126.91083527",
              "stationId": "ST-5"
          },
          {
              "rackTotCnt": "13",
              "stationName": "104. 합정역 1번출구 앞",
              "parkingBikeTotCnt": "12",
              "shared": "92",
              "stationLatitude": "37.55062866",
              "stationLongitude": "126.91498566",
              "stationId": "ST-6"
          },
          {
              "rackTotCnt": "5",
              "stationName": "105. 합정역 5번출구 앞",
              "parkingBikeTotCnt": "6",
              "shared": "120",
              "stationLatitude": "37.55000687",
              "stationLongitude": "126.91482544",
              "stationId": "ST-7"
          },
          {
              "rackTotCnt": "5",
              "stationName": "107. 신한은행 서교동지점",
              "parkingBikeTotCnt": "6",
              "shared": "120",
              "stationLatitude": "37.55751038",
              "stationLongitude": "126.91850281",
              "stationId": "ST-9"
          }
      ]
  }
}


// readFile 실패 -- 보안상의 이슈, 브라우저 작동안함
// import ~ from 실패 -- 보안상의 이슈 assert까지 붙였지만 실패
// require 실패 -- 작동안함
// request 실패 -- 사용 미숙, 이해 실패
// fetch 실패 -- 사용 미숙, 이해 실패
// js 내 모두 구현 -- 하지 않음 아무래도 분리 해서 하는 식이니 안함
// node.js -> fs -- 구현이 되지 않음 아무래도 사용 미숙
function initMap() {
  const myLatLng = { lat: 37.54864502, lng: 126.9496 };
  const map = new google.maps.Map(document.getElementById("map"), {
    zoom: 12,
    center: myLatLng,
  });


  for(var i = 0; i < json.rentBikeStatus.row.length; i++) {
  
    // Current object
    var obj = json.rentBikeStatus.row[i];

    // Adding a new marker for the object
    var marker = new google.maps.Marker({
      position: new google.maps.LatLng(obj.stationLatitude, obj.stationLongitude),
      map: map,
      title: obj.stationName // this works, giving the marker a title with the correct title
    });
  }
}

window.initMap = initMap;
