/**
 @author: Vandit Kothari/Jose Mathew
    @date : June 22,2016
    @Description: confermation message for deleting user.
    
*/

$(document).ready(function () {

    console.log("app started");

    $("a.btn.btn-danger.btn-sm").click(function () {
        return confirm("Are you sure you want to delete this record?");
    });
});