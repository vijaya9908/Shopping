var Product = {};


$(".cart-button").click(function () {
    var panel = $(this).closest(".panel");
    Product.Name = $(panel).find(".panel-heading > h3").text();
    console.log(Product.Name);
    Product.Amount = $(panel).find(".panel-body h4").data("amount");
    console.log(Product.Amount);
    addToCart(Product, this);
   
});


function addToCart(product, element) {
    $.ajax({
        url: window.location.origin + "/Cart/AddToCart",
        type: "POST",
        data: JSON.stringify(product),
        contentType: "application/json",//From Frontend to middleware
        dataType: "html",
        success: function (data) {
            $("#popupmodal").html(data);
            $("#successmodal").modal("show");
            $(element).prop("disabled", "disabled");
            
        },
        error: function () {
            alert("failure");
        }

    })

    
}