$(function () {
    //alert("Hello from Add item Page");
    
    //$("#description").on("change", function () {
    //    description = $("#description").val();
        
    //});
    //$("#itemName").on("change", function () {
    //    itemName = $("#itemName").val()
       
    //});

    //$("#count").on("change", function () {
    //    count = $("#count").val()
        
    //}),
    //$("#price").on("change", function () {
    //    price = $("#price").val()
        
    //});

    $("#addItem").on("click", function () {
        //e.preventDefault()
        //var itemName, count, price;
        //var description = $("#description").on("change", function () {
        //    return $("#description").val();
            
        //});
        //$("#itemName").on("change", function () {
        //    this.itemName = $("#itemName").val();

        //});

        //$("#count").on("change", function () {
        //    this.count = $("#count").val();

        //}),
        //$("#price").on("change", function () {
        //    this.price = $("#price").val();

        //});
        //console.log(description);
        //console.log(this.itemName);
        //console.log(this.count);
        //console.log(this.price);
        var settings = {
            "url": "https://localhost:44324/api/items/addItem",
            "method": "POST",
            "timeout": 0,
            "headers": {
                "Content-Type": "application/json"
            },
            "data": JSON.stringify({
                "item": {
                    "name": $("#itemName").val().toString(),//"Windows PC",
                    "description": $("#description").val().toString(), //"Awesome PC with NVIDIA 3090",
                    "count": $("#count").val().toString(),
                    "price": $("#price").val().toString()
                }
            }),
        };
        $.ajax(settings)
            .done(function (response) {
                console.log(response);
                alert("Item added successfuly");
            })
            .fail(function (response) {
                console.log(response);
                alert("Item could not be added at this time! Try again latter");
            });
    });

    
    //$.ajax(itemRequest)
    //    .done(response => dosomething())
    //    .fail(response => failsomething());

});