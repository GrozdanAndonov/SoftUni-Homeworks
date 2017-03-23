$(document).ready(function () {
    const urlComments="https://baas.kinvey.com/appdata/kid_HyOZEibie/comments";
    const urlPosts="https://baas.kinvey.com/appdata/kid_HyOZEibie/posts/";
    const kinveyUserName="peter";
    const kinveyPassword="p";
    const base64Auth=btoa(kinveyUserName+":"+kinveyPassword);
    const authHeaders={"Authorization":"Basic "+base64Auth};
    //Get posts
    $("#btnLoad").click(loadPosts);
    $("#viewPosts").click(viewPosts);

    function loadPosts() {
        let getPostsRequest={
            method:"GET",
            url:urlPosts,
            headers:authHeaders
        };
        $.ajax(getPostsRequest)
            .then(displayPosts)
            .fail(displayError)

    }
    function displayPosts(posts) {
        for(let post of posts)
       $("#selectPost").append(`<option value="${post._id}">${post.title}</option>`);
    }
    function displayError(err) {
        
    }
    function viewPosts() {
        let selectedPost=$("#selectPost").val();
        let postsRequest=$.ajax({
            method:"GET",
            url:urlPosts+selectedPost,
            headers:authHeaders
        });
              let commentsRequest=$.ajax({
                    method:"GET",
                    url:urlComments+`?query={"post_id":"${selectedPost}"}`,
                    headers:authHeaders
                });
        Promise.all([postsRequest,commentsRequest])
            .then(displayPostsWithComments)
            .catch(displayError);
              function displayPostsWithComments([post,comments]) {
                        $("#postTitle").text(post.title);
                        $("#postBody").text(post.body);
                        $("#comments").empty();
                        for(let com of comments){
                        $("#comments").append(`<li>${com.text}</li>`);
                    }
    }
}});
