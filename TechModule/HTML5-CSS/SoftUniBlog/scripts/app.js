let baseUrl = "https//baas.kinvey.com";
let appKey = "kid_BJr-3JiH";
let appSecret = "cfc5ab2f5c4948f3986bc392e8339923";
var _guestCredentials = "";

let selector = ".wrapper";
let mainContentSelector = ".main-content";

let authService = new AuthorizationService(baseUrl,
    appKey,
    appSecret,
    _guestCredentials);

authService.initAuthorizationType("Kinvey");

let requester = new Requester(authService);


