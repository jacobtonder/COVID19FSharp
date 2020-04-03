namespace COVID19FSharp

open FSharp.Data
open APIResources
open Samples

type Result<'TSuccess,'TFailure> =
    | Success of 'TSuccess
    | Failure of 'TFailure

type Latest = JsonProvider<LatestSample>
type LatestLocation = JsonProvider<LocationSample>
type LatestLocationCountryCode = JsonProvider<LocationCountryCodeSample>

module CovidTracker =
    let getLatestRaw =
        try
            let response = Http.Request(baseUrl + "latest", httpMethod="GET")
            let data = response.Body
            match data with
            | Text text -> Success(Latest.Parse(text))
            | _ -> Failure "getLatestRaw. Unexpected format of response message."
        with
        | ex -> Failure ex.Message

    let getLocationRaw location =
        try
            let response = Http.Request(baseUrl + "locations/" + location, httpMethod="GET")
            let data = response.Body
            match data with
            | Text text -> Success(LatestLocation.Parse(text))
            | _ -> Failure "getLocationRaw. Unexpected format of response message."
        with
        | ex -> Failure ex.Message

    let getLatestConfirmed =
        let data = getLatestRaw
        match data with
        | Success success -> Success(success.Latest.Confirmed.ToString())
        | _ -> Failure "getLatestConfirmed. Unexpected format of response message."

    let getLatestDeaths =
        let data = getLatestRaw
        match data with
        | Success success -> Success(success.Latest.Deaths.ToString())
        | _ -> Failure "getLatestDeaths. Unexpected format of response message."
    
    let getLatestRecovered =
        let data = getLatestRaw
        match data with
        | Success success -> Success(success.Latest.Recovered.ToString())
        | _ -> Failure "getLatestRecovered. Unexpected format of response message."

    let getLatestConfirmedByLocation location =
        let data = getLocationRaw location
        match data with
        | Success success -> Success(success.Location.Latest.Confirmed.ToString())
        | _ -> Failure "getLatestConfirmedByLocation. Unexpected format of response message."

    let getLatestDeathsByLocation location =
        let data = getLocationRaw location
        match data with
        | Success success -> Success(success.Location.Latest.Deaths.ToString())
        | _ -> Failure "getLatestDeathsByLocation. Unexpected format of response message."

    let getLatestRecoveredByLocation location =
        let data = getLocationRaw location
        match data with
        | Success success -> Success(success.Location.Latest.Recovered.ToString())
        | _ -> Failure "getLatestRecoveredByLocation. Unexpected format of response message."

    let getLatestConfirmedByCountryCode countryCode =
        try
            let response = Http.Request(baseUrl + "locations?country_code=" + countryCode, httpMethod="GET")
            let data = response
            match data.Body with
            | Text text -> Success(LatestLocationCountryCode.Parse(text).Latest.Confirmed.ToString())
            | _ -> Failure "getLatestConfirmedByCountryCode. Unexpected format of response message."
        with
        | ex -> Failure ex.Message

    let getLatestDeathsByCountryCode countryCode =
        try
            let response = Http.Request(baseUrl + "locations?country_code=" + countryCode, httpMethod="GET")
            let data = response
            match data.Body with
            | Text text -> Success(LatestLocationCountryCode.Parse(text).Latest.Deaths.ToString())
            | _ -> Failure "getLatestDeathsByCountryCode. Unexpected format of response message."
        with
        | ex -> Failure ex.Message

    let getLatestRecoveredByCountryCode countryCode =
        try
            let response = Http.Request(baseUrl + "locations?country_code=" + countryCode, httpMethod="GET")
            let data = response
            match data.Body with
            | Text text -> Success(LatestLocationCountryCode.Parse(text).Latest.Recovered.ToString())
            | _ -> Failure "getLatestRecoveredByCountryCode. Unexpected format of response message."
        with
        | ex -> Failure ex.Message
