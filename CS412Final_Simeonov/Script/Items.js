$(function () {
    let imagesNotDisplayed = [];
    const settings = {
        "url": "https://localhost:44324/api/items/",
        "method": "GET",
        "timeout": 0,
    };

    $.ajax(settings)
        .done((response) => {
            //console.log(response);
            //alert("Items fetched successfuly");
            response
                .slice(0, 3)
                .forEach(itemElement => {
                    console.log(itemElement);
                    let id = 'item' + itemElement.Id,
                        itemName = itemElement.Name,
                        itemDescription = itemElement.Description,
                        itemCount = itemElement.Count,
                        itemPrice = itemElement.Price;

                    $("#displayItems")
                        .append('<div class="col-sm" align="center" style="margin-top: 15px;" id="' + id + '"></div >');
                    let idselector = '#' + id;
                    $(idselector).append('<div class= "card" style = "width: 18rem;"></div>');
                    $(idselector)
                        .children('.card')
                        .append('<img class="card-img-top" src="Content/Icons/placeHolderMac.svg" alt="Card image cap">')
                        .append('<div class="card-body"></div>')
                        .children('.card-body')
                        .append('<h5 class="card-title">' + itemName + '</h5>')
                        .append('<p class="card-text">' + itemDescription + '</p >')
                        .append('<p class="card-text">Price: ' + itemPrice + ', only ' + itemCount + ' left</p >')
                        .append('<a href="#" class="btn btn-primary">Buy Now</a>');
                });
            imagesNotDisplayed = response.slice(3);
        })
        .fail((response) => {
            console.log(response);
            alert("Items could not be fetched at this time! Try again latter");
        });

    //
    $("#fetchMoreItems").on("click", function (e) {
        e.preventDefault();
        console.log("Inside the fetchMoreItems onclick,", Date.now());
        imagesNotDisplayed
            .slice(0, 3)
            .forEach(itemElement => {
                console.log(itemElement);
                let id = 'item' + itemElement.Id,
                    itemName = itemElement.Name,
                    itemDescription = itemElement.Description,
                    itemCount = itemElement.Count,
                    itemPrice = itemElement.Price;

                $("#displayItems")
                    .append('<div class="col-sm" align="center" style="margin-top: 15px;" id="' + id + '"></div >');
                let idselector = '#' + id;
                $(idselector).append('<div class= "card" style = "width: 18rem;"></div>');
                $(idselector)
                    .children('.card')
                    .append('<img class="card-img-top" src="Content/Icons/placeHolderMac.svg" alt="Card image cap">')
                    .append('<div class="card-body"></div>')
                    .children('.card-body')
                    .append('<h5 class="card-title">' + itemName + '</h5>')
                    .append('<p class="card-text">' + itemDescription + '</p >')
                    .append('<p class="card-text">Price: ' + itemPrice + ', only ' + itemCount + ' left</p >')
                    .append('<a href="#" class="btn btn-primary">Buy Now</a>');
            });

        imagesNotDisplayed = imagesNotDisplayed.slice(3);
    });
    ///

});