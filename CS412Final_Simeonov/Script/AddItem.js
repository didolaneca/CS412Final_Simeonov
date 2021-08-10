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
    let imageBase64Stringsep = "";
    let base64String;
    let imageName;
    $('#pictureInput').on('change', (function (e) {
        console.log("I'm inside the picture function");
        e.preventDefault();
        //var divPicUpload = $('#pictureInput')[0].files;
        var divPicUpload = $('#pictureInput')[0]['files'][0];
        const reader = new FileReader();
        console.log("next");
        imageName = divPicUpload.name.split('.')[0];
        console.log(imageName);
        //let imageBase64Stringsep = "";
        reader.onload = function () {
            console.log("Inside onload", Date.now());
            base64String = reader
                .result
                .replace("data:", "")
                .replace(/^.+,/, "");
            imageBase64Stringsep = base64String;
            let b64 = btoa(base64String);
            let image = new Image();
            image.src = image.src = 'data:image;base64,' + base64String;

            let picture = atob(base64String);
            //imageBase64Stringsep.concat(base64String);

            // alert(imageBase64Stringsep);
           // console.log(base64String);
            //console.log(picture);
            //let imageElement = $("<image>", { id: "foo", "class": "img-fluid", "src": picture });
            //$("#file-input-form").append(image);
            $("#divPicUpload").append(image);
        }
        reader
            .readAsDataURL(divPicUpload);
        //var pictureData = new FormData($('#divPicUpload')[0]);
        console.log("Outside reader", Date.now(),"\n", imageBase64Stringsep);
    }));

    $("#addItem").on("click", function (e) {
        e.preventDefault();
        console.log("Inside the onclick,", Date.now());
        
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
        //some text
        //$('#pictureInput').on('change', (function (e) {
        //    console.log("I'm inside the picture function");
        //    e.preventDefault();
        //    var pictureData = new FormData($('#pictureInput'));
        //    console.log(pictureData);
        //}));
        
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
                    "price": $("#price").val().toString(),
                    "images": [{
                        "ImgSrc": base64String,
                        "Description": imageName
                    }]
                }
            }),
            "success": function (response) {
                console.log(response);
                alert("Item added successfuly");
            },
            "error": function (response) {
                console.log(response);
                alert("Item could not be added at this time! Try again latter");
            }
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