module Samples
    [<Literal>]
    let LatestSample = """{    
    "latest": {
        "confirmed": 197146,
        "deaths": 7905,
        "recovered": 80840
        }
    }"""

    [<Literal>]
    let LocationSample = """{
    "location": {
        "id": 94,
        "country": "Denmark",
        "country_code": "DK",
        "province": "",
        "last_updated": "2020-03-24T22:41:09.592442Z",
        "coordinates": {
            "latitude": "56.2639",
            "longitude": "9.5018"
        },
        "latest": {
            "confirmed": 1450,
            "deaths": 24,
            "recovered": 0
        },
        "timelines": {
            "confirmed": {
                "latest": 1463,
                "timeline": {
                    "2020-03-16T00:00:00Z": 1333,
                    "2020-03-17T00:00:00Z": 1463
                    }
                }
            }
        }
    }"""

    [<Literal>]
    let LocationCountryCodeSample = """{
    "latest": {
        "confirmed": 1572,
        "deaths": 24,
        "recovered": 0
    },
    "locations": [
        {
            "coordinates": {
                "latitude": "61.8926",
                "longitude": "-6.9118"
            },
            "country": "Denmark",
            "country_code": "DK",
            "id": 92,
            "last_updated": "2020-03-24T22:41:09.580011Z",
            "latest": {
                "confirmed": 118,
                "deaths": 0,
                "recovered": 0
            },
            "province": "Faroe Islands"
        },
        {
            "coordinates": {
                "latitude": "71.7069",
                "longitude": "-42.6043"
            },
            "country": "Denmark",
            "country_code": "DK",
            "id": 93,
            "last_updated": "2020-03-24T22:41:09.586088Z",
            "latest": {
                "confirmed": 4,
                "deaths": 0,
                "recovered": 0
            },
            "province": "Greenland"
        },
        {
            "coordinates": {
                "latitude": "56.2639",
                "longitude": "9.5018"
            },
            "country": "Denmark",
            "country_code": "DK",
            "id": 94,
            "last_updated": "2020-03-24T22:41:09.592442Z",
            "latest": {
                "confirmed": 1450,
                "deaths": 24,
                "recovered": 0
            },
            "province": ""
            }
        ]
    }"""
