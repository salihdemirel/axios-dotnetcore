$(document).ready(function () { 

    $('#movieForm').on('submit', (e) => {

        var searchText = $('#filmName').val();
        getMovies(searchText);
        e.preventDefault();

    });
});

function getMovies(searchText) {

    axios.get('https://www.omdbapi.com/?s=' + searchText + '&apikey=7c854682').then((response) => {

        console.log(response);
        var movies = response.data.Search;
        var output = '';
        $.each(movies, (index, movie) => {

            output += ` 
                <div class = "col-md-4">
                    <div class = "well text-center">
                        <img src = "${movie.Poster}" style="width:100%; height:300px">
                        <h3 style="height:50px">${movie.Title}</h3>
                    </div>
                </div>
            `;

        });

        $('#movieList').html(output);
    })

        .catch((err) => {

            console.log(err);


        });
}