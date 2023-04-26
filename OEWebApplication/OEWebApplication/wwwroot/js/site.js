// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var wshNetwork = new ActiveXObject("WScript.Network");
var username = wshNetwork.username;
var computername = wshNetwork.computername;
var userdomain = wshNetwork.userdomain;
document.getElementById("userName").innerHTML = username;